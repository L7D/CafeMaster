using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CafeMaster_UI.Lib.DBProvider
{
	class SQLite
	{
		private SQLiteConnection connectionObject = null;
		private string connStr = @"Data Source = " + GlobalVar.APP_DIR + @"\data\core.db; Pooling = true; FailIfMissing = false";
		private ReaderWriterLockSlim _readerWriterLock = new ReaderWriterLockSlim( ); // http://stackoverflow.com/questions/20001129/multithreading-in-c-sharp-sqlite

		public SQLite( string dbDir, string createSQL )
		{
			connStr = @"Data Source = " + GlobalVar.APP_DIR + @"\data\" + dbDir + "; Pooling = true; FailIfMissing = false";

			connectionObject = new SQLiteConnection( connStr );
			connectionObject.Open( );

			ExecuteQuery( createSQL );
		}

		public void Open( )
		{
			connectionObject = new SQLiteConnection( connStr );
			connectionObject.Open( );
		}

		public void ExecuteQuery( string query )
		{
			try
			{
				_readerWriterLock.EnterReadLock( );

				using ( SQLiteCommand command = new SQLiteCommand( query, connectionObject ) )
				{
					command.ExecuteNonQuery( );
				}
			}
			finally
			{
				_readerWriterLock.ExitReadLock( );
			}
		}

		public void ExecuteDataReader( string query, Func<SQLiteDataReader, bool> readerCallBack )
		{
			try
			{
				_readerWriterLock.EnterReadLock( );

				using ( SQLiteCommand command = new SQLiteCommand( query, connectionObject ) )
				{
					using ( SQLiteDataReader reader = command.ExecuteReader( ) )
					{
						while ( reader.Read( ) )
						{
							if ( readerCallBack.Invoke( reader ) == false ) break;
						}
					}
				}
			}
			finally
			{
				_readerWriterLock.ExitReadLock( );
			}
		}

		public DataSet ExecuteReturnDataSet( string query )
		{
			try
			{
				_readerWriterLock.EnterReadLock( );

				using ( SQLiteDataAdapter adapter = new SQLiteDataAdapter( query, connectionObject ) )
				{
					DataSet ds = new DataSet( );

					adapter.Fill( ds );

					return ds;
				}
			}
			finally
			{
				_readerWriterLock.ExitReadLock( );
			}
		}

		public void Close( )
		{
			connectionObject.Close( );
		}
	}

	//class SQLite
	//{
	//	private static SQLiteConnection connectionObject = null;

	//	public static void Open( string dbDir )
	//	{
	//		if ( !File.Exists( dbDir ) )
	//			SQLiteConnection.CreateFile( dbDir );

	//		string connStr = @"Data Source = " + dbDir + "; Pooling = true; FailIfMissing = false";

	//		if ( connectionObject == null )
	//		{
	//			connectionObject = new SQLiteConnection( connStr );
	//			connectionObject.Open( );
	//			//if not exists

	//			ExecuteQuery( "create table if not exists articleNumbers (int num)", true );
	//		}
	//	}

	//	public static void Initialize( string dbDir, string createTableSQL )
	//	{
	//		if ( !File.Exists( dbDir ) )
	//			SQLiteConnection.CreateFile( dbDir );

	//		string connStr = @"Data Source = " + dbDir + "; Pooling = true; FailIfMissing = false";

	//		if ( connectionObject == null )
	//		{
	//			connectionObject = new SQLiteConnection( connStr );
	//			connectionObject.Open( );
	//			//if not exists

	//			ExecuteQuery( createTableSQL,, true );
	//		}
	//	}

	//	public static void Close( )
	//	{
	//		connectionObject.Close( );
	//		connectionObject = null;
	//	}

	//	public static void ExecuteQuery( string query, bool noForceCloseObject = false )
	//	{
	//		if ( connectionObject == null || connectionObject.State != ConnectionState.Open )
	//		{
	//			Open( );
	//		}

	//		using ( SQLiteCommand command = new SQLiteCommand( query, connectionObject ) )
	//		{
	//			command.ExecuteNonQuery( );

	//			if ( !noForceCloseObject )
	//				Close( );
	//		}
	//	}

	//	public static void ExecuteReader( string query, Action<SQLiteDataReader> readerCallBack )
	//	{
	//		if ( connectionObject == null || connectionObject.State != ConnectionState.Open )
	//		{
	//			Open( );
	//		}

	//		try
	//		{
	//			using ( SQLiteCommand command = new SQLiteCommand( query, connectionObject ) )
	//			{
	//				using ( SQLiteDataReader readerObject = command.ExecuteReader( ) )
	//				{
	//					while ( readerObject.Read( ) )
	//					{
	//						readerCallBack.Invoke( readerObject );
	//					}
	//				}
	//			}
	//		}
	//		finally
	//		{
	//			Close( );
	//		}
	//	}

	//	public static DataSet ExecuteDataSet( string query )
	//	{
	//		if ( connectionObject == null || connectionObject.State != ConnectionState.Open )
	//		{
	//			Open( );
	//		}

	//		DataSet ds = new DataSet( );

	//		try
	//		{
	//			using ( SQLiteCommand command = new SQLiteCommand( query, connectionObject ) )
	//			{
	//				using ( SQLiteDataAdapter adapterObject = new SQLiteDataAdapter( command ) )
	//				{
	//					adapterObject.Fill( ds );

	//					return ds;
	//				}
	//			}
	//		}
	//		finally
	//		{
	//			Close( );
	//		}
	//	}
	//}
}
