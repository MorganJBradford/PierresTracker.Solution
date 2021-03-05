## <div align="center">Scrabble Score C#</div>
#### <div align="center">📚 *Epicodus Practice Lesson # 25  (Week 1 of C#)  2/25/2021* </div> 
***<p align="right">By Daniel Adeyemi and Mike Pingel***</p>   
<p align="center">
<br>

<img alt="C#" src="https://img.shields.io/badge/c%23%20-%23239120.svg?&style=for-the-badge&logo=c-sharp&logoColor=white"/>
<img alt="made with Bash" src="https://img.shields.io/badge/Made%20with-Bash-1f425f.svg"/>
</p>

___
### 📇 This project is not in a complete or portfolio ready state, and should not be considered as representation of professional work.
___
## 🚩 *Description*:    
### *Check what score you will get from your word in scrabble!*


## 🔧 *Setup/Installation instructions:*
#### 🌐 From the web:
* Go to my GitHub repository, using following [URL](https://github.com/DanielAdeyemi/Epicodus_2_25_ScrabbleScore.git).
* Click the "Code" ![img](img/code.png) and click the 'Download zip' option ![img](img/zip.png).
* Unzip the file, navigate to the `Models` directory to check code or to the `ModelTests` directory to see tests.
#### ⚙️ From the terminal: 
* Clone my repository from GitHub using `git clone https://github.com/DanielAdeyemi/Epicodus_2_25_ScrabbleScore.git` in your terminal or GitBash
* Navigate to the downloaded folder using ***cd*** command
* Execute **code .** command in your terminal and it will open all source code in your code editor.    
⚠️ *Note: To run this project locally you will need to have .NET Core. You can check if you have .NET Core by running dotnet --version in the command line. If you do not have .NET Core please find more information and download [here](https://dotnet.microsoft.com/download/dotnet)*
### 📋 Specs:
<details>
<summary>🚥 Tests</summary>

| # | Behavior | Input |  Output | Complete |
| :------------- | :------------- | :------------- | :------------ | :-------------: |
| 01 | For empty string display 0 | "" | 0 |✅|
| 02 | For each vowel in a string add 1 point | "aou" | 3 |✅ |
| 03 | If string has 'd', 'g' add 2 points for each appearance | "aoudg" | 7 | ✅|
| 04 | If string has 'b', 'c', 'm', 'p' add 3 points for each appearance| "aodbm" | 10 | ✅|
| 05 | If string has 'f', 'h', 'v', 'w', 'y' add 4 points for each appearance | "aodbmy" | 14 | ✅ |
| 06 | If string has 'k' add 5 points for each appearance | "audfk" | 13 | ✅  |
| 07 | If string has 'j', 'x' add 8 points for each appearance | "audfkj" | 21 | ✅  |
| 08 | If string has 'q', 'z' add 10 points for each appearance | "audfkjz" | 31 | ✅  |
| 09 | Make count case insensetive | "AuDfKjz" | 31 | ✅ |
| 10 |  |  |  | ❌ |

</details>



#### 🏁 Running Tests:
* To run MS tests you will need to navigate to the `Scrabble.Tests` folder *(cd Scrabble.Tests)* in the command line and then run `dotnet restore`.
* You should now see **'obj'** folders in both the `Scrabble.Tests` folder and `Scrabble` folder.
* At this point you should be able to successfully run `dotnet test` in the command line (keep in mind you should still be in the Scrabble.Tests folder).

####  🖥️ View website:
*GitHub page is not available for this project. To view functionality you need to run `dotnet run` and pass your word after that command before press enter.*

## 🛠️ *Technologies used:*
* C# 9
* .NET Core v5.0
* MSTest
* REPL
* Git and GitHub

## 🐛 *Known bugs:*
* No know bugs at this time
* You you find any bugs, _please_ contact me via my email below.

## 📬 Contact Information
#### For any questions *[email Morgan](mailto:morganjbradford95@gmail.com)*



## 📘 *License and copyright:*

> ***© Morgan Bradford 2021***  
> ⚖️ *[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)*