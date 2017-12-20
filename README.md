# dotnet-core example source code
- dotnet-core
  - dotnet-core.sln
  - src
    - hello
  - test
    - hello-test

## 1. Pull source code from github

## 2. Build -> Test -> Run
* Build: build all projects in solution 

  `$dotnet build`
* Test: run test project
  
  `$dotnet test test/hello-test/hello-test.csproj`
* Run: run api project

  `$dotnet run --project src/hello/hello.csproj`
