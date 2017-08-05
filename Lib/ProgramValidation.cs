using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Json;

namespace CafeMaster_UI.Lib
{
	public class ProgramValidation
	{
		public enum UpdateCheckErrorResult
		{
			Success,
			WebException,
			UnknownError
		}

		public struct PatchNoteNode
		{
			public int patchType;
			public string text;
		}

		public struct UpdateResultStruct
		{
			public bool isLatestVersion;
			public string latestVersion;
			public string status;
			public string updateURL;
			public List<PatchNoteNode> patchNote;
		}

		public UpdateResultStruct? CheckNewVersion( out UpdateCheckErrorResult errorResult )
		{
			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://textuploader.com/d0hr4/raw" );
				request.Method = "GET";

				using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
				{
					using ( Stream responseStream = response.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream ) )
						{
							string versionJSONText = reader.ReadToEnd( );

							/*
							{
								"master": {
									"latestVersion": "1.9.0.0",
									"status": "public",
									"updateURL": "http://cafe.naver.com/revolution232/109979"
								},
								"patchNote": [
									{
										"patchType": 0,
										"text": "새로운 XML 문법을 적용했습니다."
									},
									{
										"patchType": 1,
										"text": "작렬한 버그 수정"
									}
								],
								"_copyright": "Copyright © 'DeveloFOX Studio - L7D' 2017"
							}
							*/

							UpdateResultStruct data = new UpdateResultStruct( );
							JsonObjectCollection versionJSONObject = ( JsonObjectCollection ) ( new JsonTextParser( ).Parse( versionJSONText ) );
							JsonObjectCollection masterNode = ( JsonObjectCollection ) versionJSONObject[ "master" ];

							if ( masterNode[ "latestVersion"].GetValue( ).ToString( ) == GlobalVar.CURRENT_VERSION )
							{
								data.isLatestVersion = true;
							}
							else
							{
								JsonArrayCollection patchNodeNode = ( JsonArrayCollection ) versionJSONObject[ "patchNote" ];

								data.isLatestVersion = false;
								data.latestVersion = masterNode[ "latestVersion" ].GetValue( ).ToString( );
								data.status = masterNode[ "status" ].GetValue( ).ToString( );
								data.updateURL = masterNode[ "updateURL" ].GetValue( ).ToString( );

								data.patchNote = new List<PatchNoteNode>( );

								foreach ( JsonObjectCollection i in patchNodeNode )
								{
									data.patchNote.Add( new PatchNoteNode( )
									{
										patchType = int.Parse( i[ "patchType" ].GetValue( ).ToString( ) ),
										text = i[ "text" ].GetValue( ).ToString( )
									} );
								}
							}

							errorResult = UpdateCheckErrorResult.Success;
							return data;
						}
					}
				}
			}
			catch ( WebException ex )
			{
				Utility.WriteErrorLog( "UpdateCheckFailed - " + ex.Message, Utility.LogSeverity.ERROR );
				errorResult = UpdateCheckErrorResult.WebException;
				return null;
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( "UpdateCheckFailed - " + ex.Message, Utility.LogSeverity.ERROR );
				errorResult = UpdateCheckErrorResult.UnknownError;
				return null;
			}
		}
	}
}
