// $(function(){
//     function Add(){
//         $(".table-striped").append(
//             "<tr>"+
//             "<td><input type='text'/></td>"+
//             "<td><input type='text'/></td>"+
//             "<td><input type='text'/></td>"+
//             "<td><input type='text'/></td>"+
//             "<td></td>"+
//             "<td><img src='images/save.png' class='btnSave'><img src='images/delete.png' class='btnDelete'/></td>"+
//             "</tr>");
//
//         $(".btnSave").on("click", Save);
//         $(".btnDelete").on("click", Delete);
//     };
//
//     function Save(){
//
//         tdName.html(tdName.children("input[type=text]").val());
//         tdSalary.html(tdSalary.children("input[type=text]").val());
//         tdAddress.html(tdAddress.children("input[type=text]").val());
//         tdProj.html(tdProj.children("input[type=text]").val());
//         tdButtons.html("<img src='images/edit.png' class='btnEdit'/><img src='images/delete.png' class='btnDelete'/>");
//
//         $(".btnEdit").on("click", Edit);
//         $(".btnDelete").on("click", Delete);
//     };
//
//     function Edit(){
//         var par = $(this).parent().parent(); //tr
//         var tdName = par.children("td:nth-child(1)");
//         var tdSalary = par.children("td:nth-child(2)");
//         var tdAddress = par.children("td:nth-child(3)");
//         var tdProj = par.children("td:nth-child(4)");
//         var tdButtons = par.children("td:nth-child(5)");
//
//         tdName.html("<input type='text' id='txtName' value='"+tdName.html()+"'/>");
//         tdSalary.html("<input type='text' id='txtSalary' value='"+tdSalary.html()+"'/>");
//         tdAddress.html("<input type='text' id='txtAddress' value='"+tdAddress.html()+"'/>");
//         tdProj.html("<input type='text' id='txtProj' value='"+tdProj.html()+"'/>");
//         tdButtons.html("<img src='images/save.png' class='btnSave'/>");
//
//         $(".btnSave").on("click", Save);
//         $(".btnEdit").on("click", Edit);
//         $(".btnDelete").on("click", Delete);
//     };
//
//     function Delete(){
//         var par = $(this).parent().parent(); //tr
//         par.remove();
//     };
//
//     $(".btnEdit").on("click", Edit);
//     $(".btnDelete").on("click", Delete);
//     $("#btnAdd").on("click", Add);
//
// });
//
//
//
//     $.ajax({
//         method: 'GET',
//         url: 'http://localhost:8083/ServiceBook.svc/Books', //change URL to your URL
//         dataType: "json"
//     }).done(function(res) {
//
//         for (i = 0; i < res.length; i++) {
//             var startDate = eval('new' + res[i].PublishDate.replace(/\//g, ' '));
//             var formattedStartDate = startDate.getDate() + "/" + startDate.getMonth() + "/" + startDate.getFullYear();
//             "<div class='table-responsive'>" +//add your class in HTML
//
//             "<table class='table table-bordered table-hover table-striped'>" +//same as above
//             "<tr >" +
//             "<th>Employee Name</th>" +
//             "<th>Employee Salary</th>" +
//             "<th>Employee Address</th>" +
//             "<th>Project</th>" +
//             "<th> </th>"
//             var div =
//                 "<tr>" +
//                 "<td>" + res[i].Title + "</td>" +
//                 "<td>" + res[i].Auther + "</td>" +
//                 "<td>" + res[i].Auther + "</td>" +
//                 "<td>" + formattedStartDate + "</td>" +
//                 "<td><img src='images/edit.png' class='btnEdit'><img src='images/delete.png' class='btnDelete'/></td>"+
//                 "</tr>" +
//                 "</table>"+"</div>"
//             $('.table-striped').append(div);
//
//         }
//     }).fail(function(err) {
//         console.log(err+"this is error");
//         // alert('error');
//
//     });
