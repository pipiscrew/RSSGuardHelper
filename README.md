# RSSGuardHelper

The following repo made for [martinrotter/rssguard](https://github.com/martinrotter/rssguard).  

On recent version of `martinrotter/rssguard` allowed users to write **custom scripts** and make possible to the user, provide feed(s) to `martinrotter/rssguard`... This has as result to enable users, to create either **notification** or **feed** for a page that not supports RSS.  

The mechanism of how to use **custom script**, described [here](https://github.com/martinrotter/rssguard/blob/master/resources/docs/Documentation.md) by  `martinrotter/rssguard` author.  

---  

This repo, created to help users, create parsers for pages not supporting RSS in a few clicks!! 

Please see this quick tutorial : 

[![IMAGE ALT TEXT](https://user-images.githubusercontent.com/3852762/219969270-4ee51b04-bea6-47c5-9a13-13af6c8b37ac.png)](https://user-images.githubusercontent.com/3852762/219969042-71a47a2e-6d6e-4d8c-b622-b8bc64ed6e74.mp4 "Presentation")
---  

## This project uses the following 3rd-party dependencies :  
* [html-agility-pack](https://github.com/zzzprojects/html-agility-pack/) - v1.11.46
* [HtmlAgilityPack.CssSelector](https://github.com/hcesar/HtmlAgilityPack.CssSelector) - v1.0.2 - without this library user has to write **XPath** selectors (example  ```//*[@id="bd"]/div[2]/div[1]/div/div[1]/div/h2/a```).

the 3rd-party dependencies merged to `HtmlAgilityPackEx.dll` and can be found on releases page.

