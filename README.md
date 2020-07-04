# WgetScraper
## Requirements
To run this program, you will need the [.NET Core CLI](https://dotnet.microsoft.com/download) installed to your system. You will also need **wget** installed to your system. 

#### Getting Wget
Wget can be installed easily on most UNIX systems by using their package manager to install `wget`. On Windows, you can look into [this](http://gnuwin32.sourceforge.net/packages/wget.htm) website for assistance in installing the program.

## Run Program
In this example we will get the `title` element from Reddit by running this command in the root directory:<br>
```sh
dotnet run "https://reddit.com" "title"
```
The result is `reddit: the front page of the internet`
***
By default, the program finds the first element that matches your second paramater, though you can specify an element by doing for example:<br>
```sh
dotnet run "https://reddit.com" 'div class="' --tag
```
This will look for the tag of the first div that has an opening tab that starts the same as `<div class="`. The result is (in my case, as Reddit's page will change constantly): <br>`<div class="_1VP69d9lk-Wk9zokOaylL" style="--background:#FFFFFF;--canvas:#DAE0E6">`
## Miscellaneous
This project is a simple test of analyzing data from strings. The code will likely be edited constantly to improve efficiency.
