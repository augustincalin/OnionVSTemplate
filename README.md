# OnionVSTemplate
Visual Studio project template for simple Web API onion architecture.

## How to
1. Open OnionWebAPI.sln
2. For each OnionTemplate.XXX project (that's it, Core, Infrastructure and Web) go to Project / Export Template
3. Export Project template and set the description, icon... wahtever you like. Do not check Automatically import the template into Visual Studio. This will open something like %USERPROFILE%\Documents\Visual Studio 2022\My Exported Templates
4. Create a folder on your hard disk that you'll use to generate the multi-project template: OnionTemplate
5. Unzip all the .zip's created in step 3 into OnionTemplate from step 4. Extract each zip in its own folder.
6. Add OnionTemplate.vstemplate file in the root of OnionTemplate folder from step 4. See the file in this repo, but what's important here are tags like: `<ProjectTemplateLink ProjectName="$safeprojectname$.Core" CopyParameters="true">`
7. Zip the content of OnionTemplate (from step 4.) into OnionTemplate.zip (including the folders from step 5.)
8. Open source.extension.vsixmanifest file from the OnionWebAPI project (which is a VSIX project) go to Assets tab and select New. Set the type to Microsoft...ProjectTemplate and add the .zip file from step 7.
9. Build the OnionWebAPI and you'll get the .vsix file which you can publish on VS MArketplace.

## Links
1. How to create a muti-project template  
https://docs.microsoft.com/en-us/visualstudio/ide/how-to-create-multi-project-templates?view=vs-2022

2. How to get a VSIX (see Deployment chapter)  
https://docs.microsoft.com/en-us/visualstudio/extensibility/creating-custom-project-and-item-templates?view=vs-2022

3. How to create a template for dotnet cli:  
https://www.youtube.com/watch?v=rdWZo5PD9Ek