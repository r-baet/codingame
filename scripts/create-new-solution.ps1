$ProjectName = Read-Host "Enter the name for the project"

$ProjectType = "easy"
$ProjectTypeChoices = '&Easy', '&Medium', '&Hard', '&Very Hard'
$ProjectTypeDecision = $Host.UI.PromptForChoice("", "What is the difficulty level?", $ProjectTypeChoices, 0)
if ($ProjectTypeDecision -eq 1) {
    $ProjectType = "medium"
} elseif ($ProjectTypeDecision -eq 2) {
    $ProjectType = "hard"
} elseif ($ProjectTypeDecision -eq 3) {
    $ProjectType = "very-hard"
} 

$Language = "C#"
$LanguageFriendly = "csharp"
$LanguageProjectExtension = "csproj"
$LanguageChoices = '&C#', '&F#'
$LanguageDecision = $Host.UI.PromptForChoice("", "What language should the project be?", $LanguageChoices, 0)
if ($LanguageDecision -eq 1) {
    $Language = "F#"
    $LanguageFriendly = "fsharp"
    $LanguageProjectExtension = "fsproj"
}

$YesNoChoices  = '&Yes', '&No'
$TestProject = $true
$TestProjectDecision = $Host.UI.PromptForChoice("", "Do you require a test project?", $YesNoChoices, 0)
if ($TestProjectDecision -eq 1) {
    $TestProject = $false
}

# Navigate to directory
$SolutionDirectory = "..\training\$ProjectType\$ProjectName\$LanguageFriendly"
dotnet new sln --name "$ProjectName-$LanguageFriendly" --output "$SolutionDirectory"

New-Item -ItemType "directory" -Name "src" -Path $SolutionDirectory
dotnet new console --name $LanguageFriendly --language $Language --output "$SolutionDirectory\src"
dotnet sln "$SolutionDirectory\$ProjectName-$LanguageFriendly.sln" add "$SolutionDirectory\src\$LanguageFriendly.$LanguageProjectExtension" -s "src"

if ($TestProject -eq $true) {
    New-Item -ItemType "directory" -Name "test" -Path $SolutionDirectory
    dotnet new xunit --name "$LanguageFriendly.tests" --language "C#" --output "$SolutionDirectory\test"
    dotnet sln "$SolutionDirectory\$ProjectName-$LanguageFriendly.sln" add "$SolutionDirectory\test\$LanguageFriendly.tests.csproj" -s "test"
    dotnet add "$SolutionDirectory\test\$LanguageFriendly.tests.csproj" package FluentAssertions
    dotnet add "$SolutionDirectory\test\$LanguageFriendly.tests.csproj" package Microsoft.NET.Test.Sdk
    dotnet add "$SolutionDirectory\test\$LanguageFriendly.tests.csproj" package xunit
    dotnet add "$SolutionDirectory\test\$LanguageFriendly.tests.csproj" package xunit.runner.visualstudio
    dotnet add "$SolutionDirectory\test\$LanguageFriendly.tests.csproj" package coverlet.collector
    dotnet add "$SolutionDirectory\test\$LanguageFriendly.tests.csproj" reference "$SolutionDirectory\src\$LanguageFriendly.$LanguageProjectExtension"
}
