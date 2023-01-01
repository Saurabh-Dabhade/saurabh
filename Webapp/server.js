var express=require("express");
var app=express();
var path=require("path");
var bodyparser=require("body-parser");
var routes=require("./routes/routers");
var mongoose=require("mongoose");
mongoose.promise=global.promise;

//connection url
        // mongodb://<server ip address>:port/<databse name>
const url='mongodb://0.0.0.0:27017/test'

//to make mongodb connection asynchronously
mongoose.connect(url,{
    //useMongoClient:true,
    connectTimeoutMS:1000
},function(err,result){
    if(err){
        console.log("error connecting mogodb");
        console.log(err);
    }
    else{
        //console.log(result);
        console.log("connection done with test database")
    }
});
app.use(bodyparser.json())
app.use(bodyparser.urlencoded({extended:false}))
app.use(express.static(path.join(__dirname,"public")))
app.use("/",routes);

//start the server
app.listen(4000);
console.log("server started at port 4000")
//module.exports=app;