[![wc-title.jpg](https://iili.io/JVp0PI.jpg)](https://iili.io/JVp0PI.jpg)

### _Created by Tyler Bates & Nathan Watkins_

## _Description_

Music Organizer is an interactive program that will take user inputted music from different genres and dynamically organize them by category. The user will then have access to these lists and each one will have click functions to give further details of the list item.


## _Setup/Installation Requirements_ 

1. Clone this projects repository into your local directory following [these](https://www.linode.com/docs/development/version-control/how-to-install-git-and-clone-a-github-repository/) instructions.

2. Open the now local project folder with [VSC](https://code.visualstudio.com/Download) or an equivalent

3. Download <a href="https://docs.microsoft.com/en-us/dotnet/core/install/runtime?pivots=os-windows">.NET Core</a> then enter the following command in the terminal to confirm installation (2.2 or higher)
```sh
dotnet -- version
``` 
4. Still in the command line, enter
```sh
dotnet tool install -g 
dotnet-script
```
5. Download [ASP.NET Core](https://dotnet.microsoft.com/download)_ To enable live viewing on a local server

6. Open project, navigate to the containing folder of the project & Enter the following command to confirm build stability 

```sh
dotnet run build 
```

7. Within that same containing folder enter the following to open a live server w/auto updated viewing
```sh
dotnet watch run
``` 
8. If you want to run tests navigate to the .Tests containing folder and run

```sh
dotnet test
```
9. Enjoy

## _Technology Used_

## <a href="https://en.wikipedia.org/wiki/C_Sharp_%28programming_language%29">C#</a>
## <a href="https://en.wikipedia.org/wiki/.NET_Core">.NET Core</a>
## <a href="https://en.wikipedia.org/wiki/Visual_Studio_Unit_Testing_Framework">MSTest</a>

## _Specs_

|Behavior|Input|Output|
|-----|-----|-----|
|User is greeted and given option to either add a new category of music|"create new category"|"5000/category/new"|
|User is given additional option to view existing categories|"view category"|"5000/category/show"|
|User will be offered to create a new category |"Click Create Category"|"5000/category"|
|User populates the category with a genre |"input"|"5000/category/{genre}"|
|Program adds input category to list of categories|"Rock"|"Rock"|
|User is prompt to add item(artist) to category(rock)|"WolfMother"|"5000/category/{Rock}/{WoflMother}"|

## _Legal_

#### MIT License

### Copyright (c) 2020 Tyler Bates & Nathan Watkins @ Epicodus

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.