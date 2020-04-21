# Brief history of the project

Back in 1989 I purchased a 2400 bps modem with which I could connect to some BBS in my city (Rimini, Italy).

Curious as usual, I got the software to install a BBS and put it into action on my pc (a modest 8086)
for personal use only.
But this gave me the opportunity to learn many things about the environment.
I took the opportunity to configure a point (i.e. I had the possibility to download the messages in my local bbs and read them offline).

One of the sysops had recreated the software on its own and it intrigued me a lot. Armed with my trusted Turbo Pascal I wrote a packer (ObjectMatrix)
and some utilities including a backdoor that was used for remote site administration.

The "Italian Crackdown" wiped out most of the Italian BBS, at the same time the internet was spreading for public use and my interests
moved elsewhere.

In the midst of the pandemic from CoViD19 I find myself wandering on the internet and I find that in fact there are still bbs accessible via the internet
with a simple telnet client, there are still updated FidoNet protocols to work on the internet.

Today I have knowledge and means well above those of 30 years ago, I have a "server" that can host the BBS (a RaspberryPi 2),
time to spend at home and so I decide to start this adventure.

## The tools

I start by installing the MariaDb database (ex MySQL) on the RaspberryPI, then it's the turn of Apache HTTPD, PHP and PhpMyAdmin to be able to manage it.

On the Windows 10 machine, Visual Studio 2019 and .NET Core 3.1 are required
We also need some extensions such as the Entity Framework for database access and Antlr 4 to be able to manage tags in text files.

A GIT repository and its sharing on GitHub cannot be missing.

We are finally ready to go.

---

|[Back](index.md)|[Home](index.md)|[Next](database.md)|
|---|---|---|