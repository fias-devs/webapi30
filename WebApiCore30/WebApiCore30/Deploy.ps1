$connectionString = $OctopusParameters["webapicore.dev.db.connectionstring"]

.\migrate.exe webapicore30.dll /connectionString="$($connectionString)" /connectionProviderName="System.Data.SqlClient"