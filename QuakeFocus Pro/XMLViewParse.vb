Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions 'Regex Compatability

Public Class XMLViewParse
    'IMPORTANT: ごく浅い MEANS VERY SHALLOW.
    Public Shared Sub importIntolist()
        Try
            Dim address As String = "https://www3.nhk.or.jp/sokuho/jishin/data/JishinReport.xml"
            Dim client As WebClient = New WebClient()
            client.Encoding = System.Text.Encoding.GetEncoding("SHIFT_JIS")
            Dim reader As StreamReader = New StreamReader(client.OpenRead(address), System.Text.Encoding.GetEncoding("SHIFT_JIS"))
            ' Console.WriteLine("raw Stream Is: " & reader.ReadToEnd())
            Dim doc As XDocument = XDocument.Parse(reader.ReadToEnd())
            Dim result1 = doc.Descendants("record").First()
            '  Console.WriteLine(result1.Attribute("date").Value)
            Dim eventDate As String = result1.Attribute("date").Value
            'Filter Date & Remove Characters

            Dim filteredDate As String = ((eventDate.Replace("年", "/")).Replace("月", "/")).Replace("日", " ")

            'Console.WriteLine("XML || " & filteredDate)


            Dim firstTime As String

            Dim result2 = From t In doc.Descendants("record")
                          Where t.Attribute("date").Value = eventDate
                          Select t

            Dim item2 As XElement = result2.Descendants("item").First()



            firstTime = (item2.Attribute("time").Value)

            Dim shindoFirstEvent As String = item2.Attribute("shindo").Value
            '  flowTopEvent.lblMaxInt.Text = shindoFirstEvent
            'Set Colors

            viewPage.topEvent.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(shindoFirstEvent)
            viewPage.topEvent.pIntensity.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(shindoFirstEvent)

            Dim filteredFirstTime As String = (firstTime.Replace("時", ":")).Replace("分ごろ", "")

            Dim firstCombinedSTR As String = filteredDate & filteredFirstTime

            viewPage.topEvent.lblDateTime.Text = firstCombinedSTR

            ' Console.WriteLine("CS 1 IS " & firstCombinedSTR) <-Debug


            'fix length count
            If shindoFirstEvent.Length = 1 Then
                viewPage.topEvent.lblMaxInt.Text = " " & shindoFirstEvent
            Else
                viewPage.topEvent.lblMaxInt.Text = shindoFirstEvent
            End If


            'Get Details
            Dim individualURL As String = (item2.Attribute("url").Value)

            '   Console.WriteLine("XML || Individual URL is: " & individualURL)

            'Read the Individual URL.

            Dim docxElement As XDocument = XDocument.Load(individualURL)

            Dim elem As XElement = XElement.Parse(docxElement.ToString())

            Dim XMLID As String

            XMLID = elem.Descendants("Earthquake").FirstOrDefault().Attribute("Id").Value


            Dim XMLEpicenter As String = elem.Descendants("Earthquake").FirstOrDefault().Attribute("Epicenter").Value
            '   Console.WriteLine("The XML is: " & XMLID)

            If My.Settings.prefixLang = "en" Then
                'require english translation
                Dim area0rx As String = Regex.Replace((translationSource.DecodeEpicenterToEnglish(XMLEpicenter)), "[^a-zA-Z0-9 ]", "")
                viewPage.topEvent.lblEpicenter.Text = area0rx


            Else
                'require japanese translation
                viewPage.topEvent.lblEpicenter.Text = XMLEpicenter

            End If

            Dim magunitude As String = elem.Descendants("Earthquake").FirstOrDefault().Attribute("Magnitude").Value
            viewPage.topEvent.lblMag.Text = "M: " & magunitude

            Dim rawDepth As String = elem.Descendants("Earthquake").FirstOrDefault().Attribute("Depth").Value
            'Allow Shallow Methods
            Dim shallowedDepth As String
            If My.Settings.prefixLang = "en" Then
                shallowedDepth = rawDepth.Replace("ごく浅い", "D: Shallow")
            Else
                shallowedDepth = "D: " & rawDepth
            End If

            Dim formattedDepth As String = shallowedDepth.Replace("km", " KM")
            viewPage.topEvent.lblDepth.Text = formattedDepth

            'Get Greatest Intensity - Weird Data Parsing

            Dim address2 As String = individualURL
            Dim client2 As WebClient = New WebClient()
            client2.Encoding = System.Text.Encoding.GetEncoding("SHIFT_JIS")
            Dim reader2 As StreamReader = New StreamReader(client.OpenRead(address2), System.Text.Encoding.GetEncoding("SHIFT_JIS"))

            Dim readerOut As String = reader2.ReadToEnd()

            Dim formattedMaxIntensity As String = readerOut.Substring(readerOut.LastIndexOf("<Relative>")).Trim


            Dim input As String = formattedMaxIntensity

            Dim numbers As List(Of Char) = New List(Of Char)()
            For Each c As Char In input
                If (Char.IsNumber(c)) Then
                    numbers.Add(c)
                Else
                    'Do Nothing

                End If
            Next

            Dim maxIntensity As Integer = 0 'Set the Max Intensity Existing

            For Each n As Char In numbers
                If n.ToString > maxIntensity Then
                    maxIntensity = n.ToString
                Else
                    'Do nothing
                End If
            Next

            '  Console.WriteLine("MAX INTENSITY IS: " & maxIntensity)

            'Sound Tracking

            If XMLID <> My.Settings.pastEventID Then
                'Play Appropriate Sound's Locale
                My.Settings.pastEventID = XMLID
                '   Console.WriteLine("Sound Playing")
                soundLangHandler.PlayInfoSound(maxIntensity)
            Else
                'Don't play sound.
                My.Settings.pastEventID = XMLID
            End If

            'Get Individual URLs for NHK Image

            Dim document As XDocument = XDocument.Load(individualURL)
            Dim area = From t In document.Descendants("Earthquake") Select t.Value
            Dim combinedXMLimg As String = (area.ElementAt(0))

            'Returns all values, require to be splitted

            Dim words As String() = combinedXMLimg.Split(New String() {".jpg"},
                                        StringSplitOptions.None)

            Dim detailIMGfilepath As String = words(0) & ".jpg" 'Require to append .JPG since string was split
            Dim localIMGfilepath As String = words(1) & ".jpg"
            Dim globalIMGfilepath As String = words(2) & ".jpg"

            'construct final URL

            Dim imgBasePath As String = "https://www3.nhk.or.jp/sokuho/jishin/"

            My.Settings.nhkD = imgBasePath & detailIMGfilepath
            My.Settings.nhkG = imgBasePath & globalIMGfilepath
            My.Settings.nhkL = imgBasePath & localIMGfilepath


            importIntoSmallList()


        Catch ex As Exception

            errorHandler.HandleError("service", "ERROR Occured in Remote XML Services. Please check your internet connection. Content: " & ex.Message, True)

        End Try

    End Sub

    Public Shared Sub importIntoSmallList()
        Dim address As String = "https://www3.nhk.or.jp/sokuho/jishin/data/JishinReport.xml"
        Dim client As WebClient = New WebClient()
        client.Encoding = System.Text.Encoding.GetEncoding("SHIFT_JIS")
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address), System.Text.Encoding.GetEncoding("SHIFT_JIS"))
        Dim doc As XDocument = XDocument.Parse(reader.ReadToEnd())

        '  Dim result2 = doc.Descendants("record")




        Dim intensityList As New List(Of String)

        Dim dateTimeList As New List(Of String)
        Dim areaList As New List(Of String)


        '   Dim outputList As New List(Of Tuple(Of String, String, String))


        Dim result1 = doc.Descendants("record")(1)


        For Each it In doc.Descendants("record")

            Dim attribute As String
            attribute = it.Attribute("date") 'set the date

            'search via each date

            Dim result3 = From g In doc.Descendants("record")
                          Where g.Attribute("date").Value = attribute




            For Each item In result3.Descendants("item") 'Get Shindo Value into Individual ordered List
                intensityList.Add(item.Attribute("shindo").Value)


            Next

            For Each item In result3.Descendants("item") 'Get Raw Time Value into Individual List
                '  intensityList.Add(item.Attribute("time").Value)

                ' Console.WriteLine(attribute & item.Attribute("time").Value)

                'insert datetime values into list
                Dim filterDate As String = attribute.Replace("年", "/").Replace("月", "/").Replace("日", "").Replace("�", "") 'Non SHIFT-JIS may not display correctly inside debugger
                Dim filterTime As String = (item.Attribute("time").Value).Replace("時", ":").Replace("分ごろ", "").Replace("�", "")
                Dim strAdd As String = filterDate & " " & filterTime

                '     Console.WriteLine(strAdd)
                dateTimeList.Add(strAdd)

            Next

            For Each item In result3.Descendants("item") 'Get Area Name

                'Account for Translations

                If My.Settings.prefixLang = "en" Then
                    Try
                        areaList.Add(translationSource.DecodeEpicenterToEnglish(item.Value))

                    Catch ex As Exception
                        areaList.Add(item.Value)
                        errorHandler.HandleError("service", "Epicenter Translation Error: " & ex.Message, False)
                    End Try

                Else
                    areaList.Add(item.Value)
                End If



            Next



        Next

        'Add the values to the list boxes


        Dim area1rx As String = Regex.Replace(areaList.Item(1), "[^a-zA-Z0-9 ]", "") 'REGEX MUST BE USED. Strings Like:
        Dim area2rx As String = Regex.Replace(areaList.Item(2), "[^a-zA-Z0-9 ]", "") ' "Sea near â€‹â€‹Chichijima Island"
        Dim area3rx As String = Regex.Replace(areaList.Item(3), "[^a-zA-Z0-9 ]", "") ' 
        Dim area4rx As String = Regex.Replace(areaList.Item(4), "[^a-zA-Z0-9 ]", "") 'Will be Fixed to:
        Dim area5rx As String = Regex.Replace(areaList.Item(5), "[^a-zA-Z0-9 ]", "") 'Sea near Chichijima Island
        Dim area6rx As String = Regex.Replace(areaList.Item(6), "[^a-zA-Z0-9 ]", "")
        Dim area7rx As String = Regex.Replace(areaList.Item(7), "[^a-zA-Z0-9 ]", "")
        Dim area8rx As String = Regex.Replace(areaList.Item(8), "[^a-zA-Z0-9 ]", "")

        viewPage.FlowSmallEvent1.lblMaxInt.Text = intensityList.Item(1) 'Start at one, first item was already displayed at first since zero based list is being used.
        viewPage.FlowSmallEvent1.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(intensityList.Item(1))
        viewPage.FlowSmallEvent1.lblMaxInt.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(intensityList.Item(1))
        viewPage.FlowSmallEvent2.lblMaxInt.Text = intensityList.Item(2)
        viewPage.FlowSmallEvent2.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(intensityList.Item(2))
        viewPage.FlowSmallEvent2.lblMaxInt.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(intensityList.Item(2))
        viewPage.FlowSmallEvent3.lblMaxInt.Text = intensityList.Item(3)
        viewPage.FlowSmallEvent3.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(intensityList.Item(3))
        viewPage.FlowSmallEvent3.lblMaxInt.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(intensityList.Item(3))
        viewPage.FlowSmallEvent4.lblMaxInt.Text = intensityList.Item(4)
        viewPage.FlowSmallEvent4.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(intensityList.Item(4))
        viewPage.FlowSmallEvent4.lblMaxInt.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(intensityList.Item(4))
        viewPage.FlowSmallEvent5.lblMaxInt.Text = intensityList.Item(5)
        viewPage.FlowSmallEvent5.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(intensityList.Item(5))
        viewPage.FlowSmallEvent5.lblMaxInt.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(intensityList.Item(5))
        viewPage.FlowSmallEvent6.lblMaxInt.Text = intensityList.Item(6)
        viewPage.FlowSmallEvent6.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(intensityList.Item(6))
        viewPage.FlowSmallEvent6.lblMaxInt.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(intensityList.Item(6))
        viewPage.FlowSmallEvent7.lblMaxInt.Text = intensityList.Item(7)
        viewPage.FlowSmallEvent7.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(intensityList.Item(7))
        viewPage.FlowSmallEvent7.lblMaxInt.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(intensityList.Item(7))
        viewPage.FlowSmallEvent9.lblMaxInt.Text = intensityList.Item(8)
        viewPage.FlowSmallEvent9.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(intensityList.Item(8))
        viewPage.FlowSmallEvent9.lblMaxInt.BackColor = colorProcessing.ReturnTileColorJMAplusMinus(intensityList.Item(8))

        viewPage.FlowSmallEvent1.lblDateTime.Text = dateTimeList.Item(1) 'Start at one, first item was already displayed at first since zero based list is being used.
        viewPage.FlowSmallEvent2.lblDateTime.Text = dateTimeList.Item(2)
        viewPage.FlowSmallEvent3.lblDateTime.Text = dateTimeList.Item(3)
        viewPage.FlowSmallEvent4.lblDateTime.Text = dateTimeList.Item(4)
        viewPage.FlowSmallEvent5.lblDateTime.Text = dateTimeList.Item(5)
        viewPage.FlowSmallEvent6.lblDateTime.Text = dateTimeList.Item(6)
        viewPage.FlowSmallEvent7.lblDateTime.Text = dateTimeList.Item(7)
        viewPage.FlowSmallEvent9.lblDateTime.Text = dateTimeList.Item(8)

        viewPage.FlowSmallEvent1.lblMaxInt.Text = intensityList.Item(1)
        viewPage.FlowSmallEvent2.lblMaxInt.Text = intensityList.Item(2)
        viewPage.FlowSmallEvent3.lblMaxInt.Text = intensityList.Item(3)
        viewPage.FlowSmallEvent4.lblMaxInt.Text = intensityList.Item(4)
        viewPage.FlowSmallEvent5.lblMaxInt.Text = intensityList.Item(5)
        viewPage.FlowSmallEvent6.lblMaxInt.Text = intensityList.Item(6)
        viewPage.FlowSmallEvent7.lblMaxInt.Text = intensityList.Item(7)
        viewPage.FlowSmallEvent9.lblMaxInt.Text = intensityList.Item(8)

        viewPage.FlowSmallEvent1.Label1.Text = areaList.Item(1)
        viewPage.FlowSmallEvent2.Label1.Text = areaList.Item(2)
        viewPage.FlowSmallEvent3.Label1.Text = areaList.Item(3)
        viewPage.FlowSmallEvent4.Label1.Text = areaList.Item(4)
        viewPage.FlowSmallEvent5.Label1.Text = areaList.Item(5)
        viewPage.FlowSmallEvent6.Label1.Text = areaList.Item(6)
        viewPage.FlowSmallEvent7.Label1.Text = areaList.Item(7)
        viewPage.FlowSmallEvent9.Label1.Text = areaList.Item(8)

        'Adjust Font Size

        If viewPage.FlowSmallEvent1.lblMaxInt.Text.Length > 1 Then
            viewPage.FlowSmallEvent1.lblMaxInt.Font = New Font("Noto Sans JP", 20, FontStyle.Regular)
        Else
            viewPage.FlowSmallEvent1.lblMaxInt.Font = New Font("Noto Sans JP", 24, FontStyle.Regular)
        End If

        If viewPage.FlowSmallEvent2.lblMaxInt.Text.Length > 1 Then
            viewPage.FlowSmallEvent2.lblMaxInt.Font = New Font("Noto Sans JP", 20, FontStyle.Regular)
        Else
            viewPage.FlowSmallEvent2.lblMaxInt.Font = New Font("Noto Sans JP", 24, FontStyle.Regular)
        End If

        If viewPage.FlowSmallEvent3.lblMaxInt.Text.Length > 1 Then
            viewPage.FlowSmallEvent3.lblMaxInt.Font = New Font("Noto Sans JP", 20, FontStyle.Regular)
        Else
            viewPage.FlowSmallEvent3.lblMaxInt.Font = New Font("Noto Sans JP", 24, FontStyle.Regular)
        End If

        If viewPage.FlowSmallEvent4.lblMaxInt.Text.Length > 1 Then
            viewPage.FlowSmallEvent4.lblMaxInt.Font = New Font("Noto Sans JP", 20, FontStyle.Regular)
        Else
            viewPage.FlowSmallEvent4.lblMaxInt.Font = New Font("Noto Sans JP", 24, FontStyle.Regular)
        End If

        If viewPage.FlowSmallEvent5.lblMaxInt.Text.Length > 1 Then
            viewPage.FlowSmallEvent5.lblMaxInt.Font = New Font("Noto Sans JP", 20, FontStyle.Regular)
        Else
            viewPage.FlowSmallEvent5.lblMaxInt.Font = New Font("Noto Sans JP", 24, FontStyle.Regular)
        End If

        If viewPage.FlowSmallEvent6.lblMaxInt.Text.Length > 1 Then
            viewPage.FlowSmallEvent6.lblMaxInt.Font = New Font("Noto Sans JP", 20, FontStyle.Regular)
        Else
            viewPage.FlowSmallEvent6.lblMaxInt.Font = New Font("Noto Sans JP", 24, FontStyle.Regular)
        End If

        If viewPage.FlowSmallEvent7.lblMaxInt.Text.Length > 1 Then
            viewPage.FlowSmallEvent7.lblMaxInt.Font = New Font("Noto Sans JP", 20, FontStyle.Regular)
        Else
            viewPage.FlowSmallEvent7.lblMaxInt.Font = New Font("Noto Sans JP", 24, FontStyle.Regular)
        End If



        If viewPage.FlowSmallEvent9.lblMaxInt.Text.Length > 1 Then
            viewPage.FlowSmallEvent9.lblMaxInt.Font = New Font("Noto Sans JP", 20, FontStyle.Regular)
        Else
            viewPage.FlowSmallEvent9.lblMaxInt.Font = New Font("Noto Sans JP", 24, FontStyle.Regular)
        End If

    End Sub
End Class
