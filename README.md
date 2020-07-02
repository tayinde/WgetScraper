# WgetScraper
## Requirements
To run this program, you will need the [.NET Core CLI](https://dotnet.microsoft.com/download) installed to your system. You will also need **wget** installed to your system. 

#### Getting Wget
Wget can be installed easily on most UNIX systems by using their package manager to install `wget`. On Windows, you can look into [this](http://gnuwin32.sourceforge.net/packages/wget.htm) website for assistance in installing the program.

## Run Program
In this example we will get the `title` element from Reddit:<br>
```sh
dotnet run "https://reddit.com" "title"
```
The result is `reddit: the front page of the internet`
***
By default, the program finds the first element that matches your second paramater, though you can specify an element by doing for example:<br>
```sh
dotnet run "https://reddit.com" 'div class="_10wC0aXnrUKfdJ4Ssz-o14"'
```
This will find a div with the class specified. This command returns `<a href="https://www.independent.co.uk/news/world/europe/russia-referendum-putin-rule-2036-yes-vote-a9595711.html" class="_13svhQIUZqD9PVzFcLwOKT styled-outbound-link" rel="noopener nofollow ugc" target="_blank">independent.co.uk/news/w...<i class="icon icon-outboundLink _2WV2dTLgPlEXLVEmIexAxf"></i></a>`
## Miscellaneous
This project is a simple test of analyzing data from strings. The code will likely be edited constantly to improve efficiency.
