Module svgStaticLocations

	Public svgHeader As String =  "<?xml version=""1.0"" encoding=""utf-8""?>

<svg xmlns=""http//www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" version=""1.1"">
	<defs>
		<style type=""text/css"">
			<!-- Do not Use Default Land Style (.land). SVG Is constructed via code.-->
			.land 
			{
				<!--fill: #CCCCCC;-->
				fill: #102f46;
				fill-opacity: 1;
				stroke:white;
				stroke-opacity: 1;
				stroke-width:0.5;
			}
			.landnotify 
			{
			
				fill: #989898;
				fill-opacity: 1;
				stroke:white;
				stroke-opacity: 1;
				stroke-width:0.5;
			}


			.one
			{
				fill: #6b7879;
				fill-opacity: 1;
				stroke:white;
				stroke-opacity: 1;
				stroke-width:0.5;
			}

			.two
			{
				fill: #156ca6;
				fill-opacity: 1;
				stroke:white;
				stroke-opacity: 1;
				stroke-width:0.5;
			}

			.three
			{
				fill: #149a4c;
				fill-opacity: 1;
				stroke:white;
				stroke-opacity: 1;
				stroke-width:0.5;
			}

			.four
			{
				fill: #c89c00;
				fill-opacity: 1;
				stroke:white;
				stroke-opacity: 1;
				stroke-width:0.5;
			}

			.fiveminus
			{
				fill: #e68a2e;
				fill-opacity: 1;
				stroke:white;
				stroke-opacity: 1;
				stroke-width:0.5;
			}

			.fiveplus
			{
				fill: #c86a0e;
				fill-opacity: 1;
				stroke:white;
				stroke-opacity: 1;
				stroke-width:0.5;
			}

			.sixminus
			{
				fill: #ec1a00;
				fill-opacity: 1;
				stroke:white;
				stroke-opacity: 1;
				stroke-width:0.5;
			}

			.sixplus
			{
				fill: #a60207;
				fill-opacity: 1;
				stroke:white;
				stroke-opacity: 1;
				stroke-width:0.5;
			}

			.seven
			{
				fill: #960097;
				fill-opacity: 1;
				stroke:white;
				stroke-opacity: 1;
				stroke-width:0.5;
			}

			.nonspecific
			{
				fill: #f9e63f;
				fill-opacity: 1;
				stroke:white;
				stroke-opacity: 1;
				stroke-width:0.5;
			}
		</style>

	</defs>
	<g>"
	Public svgFooter As String = "	</g>
</svg>"
#Region "Region and Content Declarations"
	Public AichiHeader As String = "<path id=""JP-23"" title=""Aichi"" class="""
	Public AichiFooter As String = """ d=""M274.27,277.6l-0.17,-0.35l0.5,-1.77l-0.86,-1.4l0.11,-1.46l0.46,-1.37l-0.25,-0.32l-0.89,0.36l-1.14,-0.35l0,0l-0.97,-1.57l-0.32,-1.21l0,0l0.22,-2.19l1.69,-2.97l1.28,0.15l1.66,-0.5l1.48,-1.13l-0.02,0.57l1.18,0.87l-0.03,0.65l0.5,0.21l-0.09,0.48l0.27,0.32l0.32,0.15l0.3,-0.21l0.94,0.39l0.52,0.71l0.85,-0.17l0.92,-0.73l0.63,-0.01l0.75,0.47l-0.07,0.24l0.84,0.05l-0.02,0.31l0.99,0.5l1.72,-1.4l0.8,-0.08l0,0l-0.32,0.83l0.64,0.81l-0.01,0.51l1.26,-0.26l0.85,-0.55l1.56,0.3l0.22,0.39l0.84,-0.27l0,0l-0.31,0.98l0.52,0.5l-0.58,0.57l0.08,0.47l-0.46,0.24l-1.46,2l-0.03,1.06l-1.28,1.93l-2.75,1.53l-0.43,1.23l0.16,2.32l0,0l-3.41,0.79l-3.43,1.23l-2.03,0.27l-0.26,-0.21l0.8,-1.71l0.49,0.05l0.25,0.57l2.36,-1.02l0.86,-0.53l-0.1,-0.44l0.45,-0.36l0.48,0.15l0.22,-0.19l0.21,-1.14l-0.57,-0.7l-1.69,-0.31l-0.52,0.46l-0.24,0.93l-0.81,-0.57l-2.13,0.25l-1.42,-1.37l0.31,-1.08l-0.44,-0.19l-0.42,0.59l-0.27,2.22l1.02,0.93l0.15,0.88l-1.69,-0.6L274.27,277.6z""/>"

	Public AkitaHeader As String = ""
	Public AkitaFooter As String = ""

	Public AomoriHeader As String = ""
	Public AomoriFooter As String = ""

	Public ChibaHeader As String = ""
	Public ChibaFooter As String = ""

	Public EhimeHeader As String = ""
	Public EhimeFooter As String = ""

	Public FukuiHeader As String = ""
	Public FukuiFooter As String = ""

	Public FukuokaHeader As String = ""
	Public FukuokaFooter As String = ""

	Public FukushimaHeader As String = ""
	Public FukushimaFooter As String = ""

	Public GifuHeader As String = ""
	Public GifuFooter As String = ""

	Public GunmaHeader As String = ""
	Public GunmaFooter As String = ""

	Public HyogoHeader As String = ""
	Public HyogoFooter As String = ""

	Public HokkaidoHeader As String = ""
	Public HokkaidoFooter As String = ""

	Public HiroshimaHeader As String = ""
	Public HiroshimaFooter As String = ""

	Public IbarakiHeader As String = ""
	Public IbarakiFooter As String = ""

	Public IshikawaHeader As String = ""
	Public IshikawaFooter As String = ""

	Public IwateHeader As String = ""
	Public IwateFooter As String = ""

	Public KochiHeader As String = ""
	Public KochiFooter As String = ""

	Public KagawaHeader As String = ""
	Public KagawaFooter As String = ""

	Public KumamotoHeader As String = ""
	Public KumamotoFooter As String = ""

	Public KanagawaHeader As String = ""
	Public KanagawaFooter As String = ""

	Public KagoshimaHeader As String = ""
	Public KagoshimaFooter As String = ""

	Public KyotoHeader As String = ""
	Public KyotoFooter As String = ""

	Public MieHeader As String = ""
	Public MieFooter As String = ""

	Public MiyagiHeader As String = ""
	Public MiyagiFooter As String = ""

	Public MiyazakiHeader As String = ""
	Public MiyazakiFooter As String = ""

	Public NiigataHeader As String = ""
	Public NiigataFooter As String = ""

	Public NaganoHeader As String = ""
	Public NaganoFooter As String = ""

	Public NaraHeader As String = ""
	Public NaraFooter As String = ""

	Public NagasakiHeader As String = ""
	Public NagasakiFooter As String = ""

	Public OkinawaHeader As String = ""
	Public OkinawaFooter As String = ""

	Public OsakaHeader As String = ""
	Public OsakaFooter As String = ""

	Public OkayamaHeader As String = ""
	Public OkayamaFooter As String = ""

	Public OitaHeader As String = ""
	Public OitaFooter As String = ""

	Public SagaHeader As String = ""
	Public SagaFooter As String = ""

	Public ShigaHeader As String = ""
	Public ShigaFooter As String = ""

	Public ShimaneHeader As String = ""
	Public ShimaneFooter As String = ""

	Public SaitamaHeader As String = ""
	Public SaitamaFooter As String = ""

	Public ShizuokaHeader As String = ""
	Public ShizuokaFooter As String = ""

	Public TochigiHeader As String = ""
	Public TochigiFooter As String = ""

	Public TokyoHeader As String = ""
	Public TokyoFooter As String = ""

	Public TokushimaHeader As String = ""
	Public TokushimaFooter As String = ""

	Public TottoriHeader As String = ""
	Public TottoriFooter As String = ""

	Public ToyamaHeader As String = ""
	Public ToyamaFooter As String = ""

	Public WakayamaHeader As String = ""
	Public WakayamaFooter As String = ""

	Public YamaguchiHeader As String = ""
	Public YamaguchiFooter As String = ""

	Public YamanashiHeader As String = ""
	Public YamanashiFooter As String = ""

	Public YamagataHeader As String = ""
	Public YamagataFooter As String = ""

#End Region

	Public Function ConstructSVG()
		Dim constructedSvgString As String = svgHeader & AichiHeader & "fiveplus" & AichiFooter & svgFooter

		'	Console.WriteLine(constructedSvgString)
	End Function



End Module
