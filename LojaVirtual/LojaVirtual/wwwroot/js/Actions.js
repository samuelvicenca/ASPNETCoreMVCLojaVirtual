$(document).ready(function () {
    $(".btn-danger").click(function (e) {
        var resultado = confirm("Tem certeza que deseja realizar essa operação?");

        if (resultado == false) {
            e.preventDefault();
        }
    })

    $('.dinheiro').mask('000.000.000.000.000,00', { reverse: true });

    AjaxUploadImagemProduto();
})

function AjaxUploadImagemProduto() {
    $(".img-upload").click(function () {
        $(this).parent().find(".input-file").click();
    });
    $(".bnt-imagem-excluir").click(function () {
        $(this).parent().find("input[name=imagem]");
    });

    $(".input-file").change(function () {
        //Fomulário de dados via JavaScript
        var Binario = $(this)[0].files[0];
        var Formulario = new FormData();
        Formulario.append("file", Binario);

        //Recupera imagem
        var CampoHidden = $(this).parent().find("input[name=imagem]");
        var Imagem = $(this).parent().find(".img-upload");
        //Requisicao Ajax enviado a Formulario
        $.ajax({
            type: "POST",
            url: "/Colaborador/Imagem/Armazenar",
            data: Formulario,
            contentType: false,
            processData: false,
            error: function () {
                alert("Erro no envio do arquivo!");
            },
            success: function () {                
                var caminho = data.caminho;
                Imagem.attr("src", caminho);
                CampoHidden.val(caminho);
            }            
        });
    });

}

