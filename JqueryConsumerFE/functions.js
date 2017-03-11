function Edit(id){
var par = id;
  $.ajax({
       type: "PUT",
       url: "http://localhost:8258/Magic.svc/UpdateEmployee",
      //  data: JSON.stringify(json3),
       contentType: "application/json; charset=utf-8",
       dataType: "json"
}).done(function(){
  $('tr td:nth-child(1,1) ').each(function () {
      var html = $(this).html();
      var input = $('<input type="text" />');
      input.val(html);
      $(this).html(input);
  });
}).fail(function(){

})



};

function Delete(id){
      var par = id;
  $.ajax({
       type: "DELETE",
       url: "http://localhost:8258/Magic.svc/DeleteEmployee/"+par,
      //  data: JSON.stringify(json2),
       contentType: "application/json; charset=utf-8",
       dataType: "json"
}).done(function(res){
  console.log(res);
  location.reload(true);
}).fail(function(){

})

};

function Save(){

    //  par = $(this).parent().parent(); //tr
    //  tdId = par.children("td:nth-child(1)");
    //  tdName = par.children("td:nth-child(2)");
    //  tdSalary = par.children("td:nth-child(2)");
    //  tdAddress = par.children("td:nth-child(3)");
    //  tdProj = par.children("td:nth-child(5)");
    //  tdProjName = par.children("td:nth-child(6)");
    //  tdButtons = par.children("td:nth-child(7)");
    //
    // var w1=  tdId.html(tdId.children("input[type=text]").val());
    //   var w2= tdName.html(tdName.children("input[type=text]").val());
    //    var w3=tdSalary.html(tdSalary.children("input[type=text]").val());
    // var w4=tdAddress.html(tdAddress.children("input[type=text]").val());
    // var w5=  tdProj.html(tdProj.children("input[type=text]").val());
    //   var w6=tdProjName.html(tdProjName.children("input[type=text]").val());


    var empidtxt=document.getElementById("empid").value;
    var empnametxt=document.getElementById("empname").value;
    var empaddretxt=document.getElementById("Empaddre").value;
    var empempsaltxt=document.getElementById("empsal").value;
    var projidtxt=document.getElementById("projid").value;
    var pronametxt=document.getElementById("proname").value;

     var json1s =   {
      "EmpAddress":empaddretxt,
      "EmpId":empidtxt,
      "EmpName":empnametxt,
      "EmpSalary":empempsaltxt,
      "ProjectId":projidtxt,
      "ProjectName":pronametxt
   }
     $.ajax({
          type: "POST",
          url: "http://localhost:8258/Magic.svc/InsertEmployee",
          data: JSON.stringify(json1s),
          contentType: "application/json; charset=utf-8",
          dataType: "json"
   }).done(function(err){
      console.log(err);

   }).fail(function(){

   })
var par;
var tdId ;
var tdName ;
var tdSalary ;
var tdAddress ;
var tdProj;
var tdProjName ;
var tdButtons ;
// tdId.html(tdId.children("input[type=text]").val());
// tdName.html(tdName.children("input[type=text]").val());
// tdSalary.html(tdSalary.children("input[type=text]").val());
// tdAddress.html(tdAddress.children("input[type=text]").val());
// tdProj.html(tdProj.children("input[type=text]").val());
// tdProjName.html(tdProjName.children("input[type=text]").val());

$(function(){
    // function Add(){
    //     $(".table-striped").append(
    //         "<tr>"+
    //         "<td><input type='text'/></td>"+//emp id
    //         "<td><input type='text'/></td>"+//emp addres
    //         "<td><input type='text'/></td>"+//emp salary
    //         "<td><input type='text'/></td>"+//emp name
    //         "<td><input type='text'/></td>"+//project id
    //         "<td><input type='text'/></td>"+//project name
    //         "<td></td>"+
    //         "<td><img src='images/save.png' class='btnSave'><img src='images/delete.png' class='btnDelete'/></td>"+
    //         "</tr>");
    //
    //     $(".btnSave").on("click", Save);
    //     $(".btnDelete").on("click", Delete);
    // };


        // tdId.html(tdId.children("input[type=text]").val());
        // tdName.html(tdName.children("input[type=text]").val());
        // tdSalary.html(tdSalary.children("input[type=text]").val());
        // tdAddress.html(tdAddress.children("input[type=text]").val());
        // tdProj.html(tdProj.children("input[type=text]").val());
        // tdProjName.html(tdProjName.children("input[type=text]").val());
        // tdButtons.html("<img src='images/edit.png' class='btnEdit'/><img src='images/delete.png' class='btnDelete'/>");

        $(".btnEdit").on("click", Edit);
        $(".btnDelete").on("click", Delete);
    });






};

//arasny
$('body').ready(function(){

  $.ajax({

    url:"http://localhost:8258/Magic.svc/Employees",
    method:"GET",
    dataType: 'json',
  xhrFields: { withCredentials: true }
  }).done(function(res){
    for(i=0;i<res.length;i++){
      "<div class='table-responsive'>" +//add your class in HTML

      "<table class='table table-bordered table-hover table-striped'>" +//same as above
      "<tr >" +
      "<th>Employee Name</th>" +
      "<th>Employee Salary</th>" +
      "<th>Employee Address</th>" +
      "<th>Project</th>" +
      "<th> </th>"
      var div =
          "<tr id='"+res[i].EmpId+"'>" +
          "<td>" + res[i].EmpId + "</td>" +
          "<td>" + res[i].EmpName + "</td>" +
          "<td>" + res[i].EmpSalary + "</td>" +
          "<td>" + res[i].EmpAddress + "</td>" +
          "<td>" + res[i].ProjectId + "</td>" +
          "<td>" + res[i].ProjectName + "</td>" +
          "<td><button onclick='Edit(\""+res[i].EmpId+"\")'>edit </button><button onclick='Delete(\""+res[i].EmpId+"\")'>del</button></td>"+
          "</tr>" +
          "</table>"+"</div>"
      $('.table-striped').append(div);
          }
// $('.first').append(div);

  }).fail(function(res){
    console.log("Failed");
  })
//$.ajax({
//  url:"http://localhost:8258/Magic.svc/InsertEmployee",
//  method:"POST"
//})


//   var json1s =   {
//   	"EmpAddress":"tdAddress.html(tdAddress.children('input[type=text]').val())",
//   	"EmpId":"tdId.html(tdId.children('input[type=text]').val())",
//   	"EmpName":"tdName.html(tdName.children('input[type=text]').val())",
//   	"EmpSalary":"tdSalary.html(tdSalary.children('input[type=text]').val())",
//   	"ProjectId":"tdProj.html(tdProj.children('input[type=text]').val())",
//   	"ProjectName":"tdProjName.html(tdProjName.children('input[type=text]').val())"
// }



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
