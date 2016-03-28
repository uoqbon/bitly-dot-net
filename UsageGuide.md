# Code Usage #

## The traditional way ##

```
	IBitlyService s = new BitlyService("youraccount", "R_XYZ");

	string shortened;
	if (s.Shorten("http://cnn.com", out shortened) == StatusCode.OK)
	{
		// do something with "shortened"
	}

```


Or if you don't care about the return code, there is a simpler overload of the **Shorten** method:


```
	IBitlyService s = new BitlyService("youraccount", "R_XYZ");
	
	string shortened = s.Shorten("http://cnn.com");
	if (shortened != null)
	{
		// do something with "shortened"
	}
```

And if you need to shorten multiple URLs at once:

```
        IBitlyService s = new BitlyService("youraccount", "R_XYZ")
        StatusCode status;
        IBitlyResponse[] shortenedUrls = s.Shorten(new string[] { "http://cnn.com", "http://google.com" }, out status);
```

## The .NET MVC Way ##

You can also use BitlyDotNET with an IoC Container of your choice. Please see [Autofac](http://code.google.com/p/autofac/) or [Castle Windsor Container](http://www.castleproject.org/container/index.html) to learn how you can achieve such a compact setup:

```
	public HomeController(IBitlyService bitlyService)
	{
		string shortened = bitlyService.Shorten("http://cnn.com");
	}
```

# Error Handling #

Please refer to the documentation to have a list of the exceptions that could be thrown.

The documentation is pretty complete (see **Downloads** section), so I advise you to refer to it to properly handle any situation or error you may encounter when calling a particular method.