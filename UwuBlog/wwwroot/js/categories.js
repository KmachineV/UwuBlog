var dataTable;

$(document).ready(function () {
    loadDatatable();
});


function loadDatatable(){
    dataTable = $("#tblCategories").DataTable({
        "ajax": {
            "url": "/Admin/Categories/GetAll",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "Id", "width": "5%" },
            { "data": "Name", "width": "50%" },
            { "data": "Order", "width": "20%" },
            {
                "data": "Id",
                "render": function (data) {
                    return ` <div class="text-center">0
                                     <a href='/Admin/Categories/Edit/${data}' class="btn btn-success text-white" style="cursor:pointer; width:100px;"
                                     <i class='fas fa-edit'></i> Editar
                                     </a>

                                     &nbsp;
                
                                     <a onclick=Delete('/Admin/Categories/Delete/${data}') class="btn btn-danger text-white" style="cursor:pointer; width:100px;"
                                     <i class='fas fa-edit'></i> Borrar
                                     </a>
                              
                            `;
                }, "width": "30%" 
            },
        ],

        "language": {
            "emptyTable": "No hay Registro"
        },
        "width": "100%"

    });
}

function Delete(url){
    swal({
        title: "¿Desea borrar registro?",
        text: "¡Este contenido no se puede recueprar!",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6855",
        confirmButtonText: "Si, borrar",
        closeOnconfirm: true

    },  function () {

        $.ajax({
            type: 'DELETE',
            url: url,
            success: function(data) {
                if (data.success) {
                    toastr.success(data.message);
                    dataTable.ajax.reload();
                }
                else {
                    toastr.error(data.message);
                }
            }

        });

    });
}