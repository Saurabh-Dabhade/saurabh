var express=require("express");
var router=express.Router();
var mongoose=require("mongoose");
const { modelNames } = require("mongoose");
var mongoose=require("mongoose");
var schema=mongoose.Schema;

//design model using mongoose schema
var empschema=new schema({
   // _id:Number,
    empid:Number,
    ename:{type:String,trim:true,required:true},
    sal:String
//sal:{type:Number,validate:/[0-9]*/}
})
//import 'employee' from '../app';

var Emp=mongoose.model('emptab',empschema,'emptab');
router.get("/",(req,res)=>{console.log('Inside the function');
res.send('How are you')})

router.get("/employee",(req,res)=>
 {
 Emp.find().exec(function(err,data){
    if(err){
        res.status(500).send("no data found");
    }
    else{
        res.send(data);console.log('Inside the function');
    }
   });
});

//to add data handle post request
router.post("/employee",function(req,resp){
    var empob=new Emp({empid:req.body.empid,ename:req.body.ename,sal:req.body.sal})
    empob.save(function(err,data){
           if(err){
            console.log(err);
             resp.status(500).send("no data added");
           }else{
            resp.send(data);
           }
    })
});


module.exports=router;