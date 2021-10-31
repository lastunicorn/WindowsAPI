. .\config.ps1

if (Test-Path "$packagesDirectory")
{
	Remove-Item "$packagesDirectory" -Recurse
}

dotnet pack --configuration Release --output "$packagesDirectory" "..\WindowsApi.sln"
nuget pack DustInTheWind.WindowsApi.nuspec -OutputDirectory "$packagesDirectory" -Version "$version"