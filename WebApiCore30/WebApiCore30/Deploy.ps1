$connectionString = $OctopusParameters["webapicore.dev.db.connectionstring"]
ls
migrate.exe webapicore30.dll /connectionString="$($connectionString)" /connectionProviderName="System.Data.SqlClient"