var div;
$('body').ready(function(){

  $.ajax({

    url:"http://localhost:8258/Magic.svc/Employees",
    method:"GET",
    dataType: 'json',
  xhrFields: { withCredentials: true }
  }).done(function(res){
    for(i=0;i<res.length;i++){
       div=  "<input type='text' value='"+JSON.stringify(res)+"'/>"
    }
$('.first').append(div);

  }).fail(function(res){
    console.log("Failed");
  })
//$.ajax({
//  url:"http://localhost:8258/Magic.svc/InsertEmployee",
//  method:"POST"
//})


var json1s =   {
  	"EmpAddress":"String content",
  	"EmpId":22,
  	"EmpName":"String",
  	"EmpSalary":12678967.543233,
  	"ProjectId":10,
  	"ProjectName":"String content"
  }



$( "#as" ).click(function() {
  $.ajax({
       type: "POST",
       url: "http://localhost:8258/Magic.svc/InsertEmployee",
       data: JSON.stringify(json1s),
       contentType: "application/json; charset=utf-8",
       dataType: "json"
}).done(function(){

}).fail(function(){

})
  })
var json2=13
  $( "#del" ).click(function() {
    $.ajax({
         type: "DELETE",
         url: "http://localhost:8258/Magic.svc/DeleteEmployee/"+json2,
         data: JSON.stringify(json2),
         contentType: "application/json; charset=utf-8",
         dataType: "json"
  }).done(function(res){
    console.log(res);
  }).fail(function(){

  })
    })
    var json3 =   {
      	"EmpAddress":"String content",
      	"EmpId":15,
      	"EmpName":"String",
      	"EmpSalary":12678967.543233,
      	"ProjectId":10,
      	"ProjectName":"String content"
      }
$( "#up" ).click(function() {
      $.ajax({
           type: "PUT",
           url: "http://localhost:8258/Magic.svc/UpdateEmployee",
           data: JSON.stringify(json3),
           contentType: "application/json; charset=utf-8",
           dataType: "json"
    }).done(function(){

    }).fail(function(){

    })
      })
      var json4 =  "asasa"

  $( "#getName" ).click(function() {
        $.ajax({
             type: "GET",
             url: "http://localhost:8258/Magic.svc/Employee?Name="+json4,
             data: JSON.stringify(json4),
             contentType: "application/json; charset=utf-8",
             dataType: "json"
      }).done(function(){

      }).fail(function(){

      })
        })
        var json5 =  15

    $( "#getId" ).click(function() {
          $.ajax({
               type: "GET",
               url: "http://localhost:8258/Magic.svc/Employee/"+json5,
               data: JSON.stringify(json5),
               contentType: "application/json; charset=utf-8",
               dataType: "json"
        }).done(function(){

        }).fail(function(){

        })
          })
});
