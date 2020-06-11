-Install package Newtonsoft.Json.Linq<br/>
-Use this code:<br/>
///////////////<br/>
<code>
	TinsoftProxy myProxy;

	//Main

	if(myProxy==null){
		myProxy = new TinsoftProxy("");
	}
	myProxy.api_key=""; //input api key
	myProxy.location=0; //input location (0 for random)
	string proxy="";
	string ip="";
	int port=0;
	while(true){
	    if(myProxy.changeProxy()){
	                proxy = myProxy.proxy;
			ip=myProxy.ip;
			port= myProxy.port;
			break;

		}else{
			string errorCode = myProxy.errorCode;
			Console.WriteLine(errorCode);
		}
		Thread.Sleep(10000);
	}
</code>
