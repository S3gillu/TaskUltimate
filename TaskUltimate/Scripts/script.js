$(document).ready(function () {
    $('#TableId').DataTable
    ({
        "columnDefs": [
          {
              "width": "5%",
              "targets": [0]
          },
          {
              "className": "text-center custom-middle-align",
              "targets": [0, 1, 2, 3, 4, 5, 6]
          }, ],
        "language":
        {
            "processing": "<div class='overlay custom-loader-background'><i class='fa fa-cog fa-spin custom-loader-color'></i></div>"
        },
        "processing": true,
        "serverSide": true,
        "ajax":
      {
          "url": "/Plugin/GetData",
          "type": "POST",
          "dataType": "JSON"
      },
        "columns": [
          {
              "data": "Id"
          },
          {
              "data": "Name"
          },
          {
              "data": "Email"
          },
          {
              "data": "Phone"
          },
          {
              "data": "Stream"
          },
          {
              "data": "PermanentAddress"
          },
          {
              "data": "FatherName"
          },
          {
              "data": "Action"
          }]

    });
})

var WorkerData = context.TraineeVMs.OrderBy(a => a.Name).ToList();
var dataitems = [];
$.each(WorkerData, function (i, item) {
    var data = [];
    data.push(item.Id);
    data.push(item.Name);
    data.push(item.Email);
   
    dataitems.push(data);
});

$(document).ready(function () {
    $('#Jdatatable').DataTable({
        data: dataitems,
        columns: [
            { title: "Id" },
            { title: "Name" }
        ]
    });
});

    
 
    


