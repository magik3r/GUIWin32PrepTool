# GUIWin32PrepTool

### Purpose:
This program provides a user-friendly GUI for the **Microsoft Win32 Content Prep Tool** to substitute using the application through command-line.



## Prerequisites:
- #### [Microsoft Win32 Content Prep Tool](https://github.com/microsoft/Microsoft-Win32-Content-Prep-Tool)
Note that the ***IntuneWinAppUtil.exe*** must be placed in the same directory as this application. I have chosen to not bundle the content prep tool with this application to make it easier to use different versions of the prep tool.



### Usage:
- Run the application as administrator (will try to run as admin by default) and select the correct file/folder(s)*
<br/>\*
*The selections are the same as the ones you would input through command-line*
- A shell window displaying the output of the IntuneWinAppUtil.exe will open upon creating the .intunewin file, which will be named after the ***setup file***
- The box at the bottom displays the command used in case you need to troubleshoot.



### Cool Repos:
- [aaronparker/icons](https://github.com/aaronparker/icons) Neat collection of various app-icons that can be used for the Company Portal 


### Planned features:
- Include option to specify catalog folder.
- Option to name .intunewin file differently from setup file.

This is a hobby-project of mine so updates will be sporadic.
