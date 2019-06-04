This project consists of two parts, a .NET Core 2.2 Web API and a ReactJS web app that displays the message from the Web API, "Hello, world".

1) We would like you to create Docker files for both apps. 
2) The two apps need to be deployed to containers 
3) Ansible playbook that pulls the apps from Github, containerizes them, deploys them, and runs tests on them to make sure that they communicate with one another. 
4) script/playbook/runbook/pipeline definition that does #3 along with whatever instructions are necessary to run that script successfully.

Ideally, we would like you to use some kind of CI/CD pipeline toolset. You can choose locally-installed or cloud-based, but you must provide us with whatever instructions are necessary to use local tools, or grant us access to your cloud-based pipeline. Bonus points for using a Kubernetes package manager such as Helm.

## HelloWorld.WebAPI
This is a .NET Core 2.2 Web API - nothing special. Restore all NuGet packages to the solution, F5, and you should be off to the races.

## HelloWorld.WebApi.Tests
A simple test of the HelloWorld controller in the HelloWorld.WebAPI project.

## helloworld.webapp
The React app. `npm start` and all that. If it can read the Web API, it should display "Hello, world" - if it can't, it will read "placeholder"

The project directory contains the standard React bootstrapped ReadMe.md

