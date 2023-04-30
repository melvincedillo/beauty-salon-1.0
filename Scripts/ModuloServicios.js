﻿var productos = [];

var numero = /^\d*\.?\d*$/;

calcularTotal();

$(function () {
    $("#addInsumo").click(function () {
        if (id != "" && nombre != "" && precio != "" && cantidad != "") {
            var id = $("#idProduct").val();
            var nombre = $("#nombreProduct").val();
            var precio = $("#precioProduct").val();
            var cantidad = $("#cantProduct").val();
            var total = parseFloat(precio) * parseFloat(cantidad);

            var data = {
                id: id,
                nombre: nombre,
                precio: parseFloat(precio),
                cantidad: parseFloat(cantidad),
                total: total
            };

            addProduct(data);
            limpiar();
            calcularTotal();
        }
    });

    $("#precioProducto").keyup(function () {
        calcularTotal();
    });
});

function limpiar() {
    $("#idProduct").val("");
    $("#nombreProduct").val("");
    $("#precioProduct").val("");
    $("#cantProduct").val("");
}

function deleteProduct(id) {
    let elementos = [];
    for (const d of productos) {
        if (d.id != id) {
            elementos.push(d);
        }
    }
    productos = elementos;
    $("#" + id).remove();
    calcularTotal();
}

function addProduct(data) {
    let esta = false;
    let produ;
    let elementos = [];
    for (const d of productos) {
        if (d.id == data.id) {
            esta = true;
            produ = d;
        } else {
            elementos.push(d);
        }
    }

    if (esta == true) {
        produ.cantidad = produ.cantidad + data.cantidad;
        produ.total = produ.total + data.total;
        elementos.push(produ);
        addInTabla(produ);
        productos = elementos;
    } else {
        productos.push(data);
        addInTabla(data);
    }
}

function addInTabla(data) {
    var accion = $('#accion').val();
    if (accion != null) {
        var fila = '<tr> <td>' + data.nombre + '</td> <td>' + data.precio + '</td>' +
            '<td><button type="button">-</button></td></tr>';

        $('#tblProductos tbody').append(fila);
    }

    else {
        $("#" + data.id).remove();
        $("#tableProducts").append(
            '<tr id = "' + data.id + '"><td>'
            + data.nombre + '</td><td>'
            + data.cantidad + '</td><td>'
            + data.precio + '</td><td>'
            + data.total + '</td>' +
            '<td><button class="btn btn-sm btn-danger" type="button" onclick="deleteProduct(' + data.id + ');">Quitar</button></td></tr>'
        );

    }
    
}

function calcularTotal() {
    let total = 0;
    let precio = $("#precioProducto").val();
    for (const tol of productos) {
        total = total + tol.total;
    }
    if (numero.test(precio) && precio != "") {
        total = total + parseFloat(precio);
    }

    $("#totalServicio").val(total);
}