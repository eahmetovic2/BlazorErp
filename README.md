# BlazorERP Webassembly and AutoTimeAnalysis
AutoTimeAnalysis is a Chrome Extension that allows users to store and analyse a series of actions (mouse clicks, keyboard inputs...) on web apps. The extension is primarily used to measure the duration of each user defined action and to create accompanying reports.

## Installation
* Open Chrome Extension Management page by navigating to chrome://extensions.
  * The Extension Management page can also be opened by clicking on the Chrome menu, hovering over More Tools then selecting Extensions.
* Enable Developer Mode by clicking the toggle switch next to Developer mode.
* Click the LOAD UNPACKED button and select the extension directory.

## Usage example
* Click on Record button to start recording  
![alt text](https://github.com/eahmetovic2/BlazorErp/blob/master/AutoTimeAnalysis/usage/RecordBtn.jpg)
* Execute actions on the web app where the recording is started
* Click on Stop button to stop recording  
* To view details of all reports click on Open details
* Click on the Play button in the list All recordings for a detailed report
![alt text](https://github.com/eahmetovic2/BlazorErp/blob/master/AutoTimeAnalysis/usage/ReportExample.jpg)
* Click on the Download button in the list All recordings to download a json file with the recording data
* To compare a recording with a previous one click on the Choose File button in the list All recordings and upload a previous recording. The detailed reports of both recordings are then displayed next to each other for easier comparing
![alt text](https://github.com/eahmetovic2/BlazorErp/blob/master/AutoTimeAnalysis/usage/CompareExample.jpg)
* Analyse the generated reports
