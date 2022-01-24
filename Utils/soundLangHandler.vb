Imports System.Text
Imports System.Runtime.InteropServices


Public Class soundLangHandler



    Public Shared Function PlayInfoSound(intensity As String)
#Region "sounds"



#End Region
        Dim msInfo As New MultiSounds


        Dim baseSoundPath As String = Application.StartupPath & "\sounds"
        Dim finalSoundPath As String
        If My.Settings.soundLang = "en" Then
            'English Speaker
            Dim soundPath2 As String = baseSoundPath & "\en"

            If My.Settings.soundSpeaker = "female" Then
                finalSoundPath = soundPath2 & "\info-female\"
            Else
                finalSoundPath = soundPath2 & "\info-male\"
            End If


        Else
            'Japanese Speaker
            Dim soundPath2 As String = baseSoundPath & "\jp"

            If My.Settings.soundSpeaker = "female" Then
                finalSoundPath = soundPath2 & "\info-female\"
            Else
                finalSoundPath = soundPath2 & "\info-male\"
            End If


        End If

        'Play the Sound

        msInfo.AddSound("pb1", finalSoundPath & intensity & ".wav")
        msInfo.Play("pb1")

        Return True

    End Function
End Class
