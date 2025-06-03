# Introduction

b64 is a command-line application to base64 encode and decode information.

# Usage

`b64 [-e|-d] <text>`

where

  `-e`: encode to base64 (default is decode)

  `-d`: decode from base64`

Example

`b64 -e this is a test` -> outputs `dGhpcyBpcyBhIHRlc3Q=`

`b64 dGhpcyBpcyBhIHRlc3Q=` -> outputs `this is a test`

# Download

Downloads are available as [Github Releases](https://github.com/btigi/b64/releases/latest)

# Compiling

To clone and run this application, you'll need [Git](https://git-scm.com) and [.NET](https://dotnet.microsoft.com/) installed on your computer. From your command line:

```
# Clone this repository
$ git clone https://github.com/btigi/b64

# Go into the repository
$ cd src

# Build  the app
$ dotnet build
```

# Licencing

b64 is licenced under the MIT license. Full licence details are available in license.md