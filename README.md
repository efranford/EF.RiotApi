EF.RiotApi
==========

A .NET library to make calls to and from the RiotApi simpler


Simple Steps To Use
--------
Add your api key to the app config in the tests and the main library. If you don't have one get it at:

https://developer.riotgames.com/

From there you should be pretty good to go.  Just call into RiotWeb to do what you need to. 


Side Note:
--------
Check out the tests to see how calls are made.


Update
--------
I was a dofus and left my app config in an old commit in the tests projectso you could use my key.  Thanks to everyone that let me know.  I've removed it and now you should be able to just modify what's there and it should work for you!

If you are missing an app.config please add the following in an "app.config" file to both the Tests project as well as lib:

&lt;?xml version="1.0" encoding="utf-8" ?&gt;<br/>
&lt;configuration&gt;<br/>
  &lt;appSettings&gt;<br/>
    &lt;add key="ApiKey" value="[YOUR KEY HERE]"/&gt;<br/>
    &lt;add key="ApiUrl" value="https://prod.api.pvp.net/api/lol" /&gt;<br/>
    &lt;add key ="ApiRegion" value="na" /&gt;<br/>
    &lt;add key ="ApiVerision" value="v1.1" /&gt;<br/>
    &lt;add key ="CachingEnabled" value="true" /&gt;<br/>
  &lt;/appSettings&gt;<br/>
&lt;/configuration&gt;<br/>

Thanks for your help everyone!
