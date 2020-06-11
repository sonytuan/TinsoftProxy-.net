-Install package Newtonsoft.Json.Linq
-Use this code:
///////////////

TinsoftProxy myProxy = new TinsoftProxy("");

//Main
myProxy.api_key=""; // input api key
myProxy.location=""; // input location (0 for random)
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
	Thread.sleep(10000);
}
