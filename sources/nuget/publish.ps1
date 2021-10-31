. .\config.ps1
. .\nuget-api-key.ps1

$packages = @(
	"DustInTheWind.WindowsApi.$version.nupkg",
	"DustInTheWind.WindowsApi.Core.$version.nupkg",
	"DustInTheWind.WindowsApi.Errhandlingapi.$version.nupkg",
	"DustInTheWind.WindowsApi.Fileapi.$version.nupkg",
	"DustInTheWind.WindowsApi.Handleapi.$version.nupkg",
	"DustInTheWind.WindowsApi.Sysinfoapi.$version.nupkg",
	"DustInTheWind.WindowsApi.Winbase.$version.nupkg",
	"DustInTheWind.WindowsApi.Windef.$version.nupkg",
	"DustInTheWind.WindowsApi.Wingdi.$version.nupkg",
	"DustInTheWind.WindowsApi.Winnt.$version.nupkg",
	"DustInTheWind.WindowsApi.Winuser.$version.nupkg"
)

foreach ($package in $packages) {
	$packagePath = Join-Path -Path "$packagesDirectory" -ChildPath "$package"
	dotnet nuget push "$packagePath" --api-key "$apiKey" --source https://api.nuget.org/v3/index.json
}