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
    //Deletar imagem
    $(".btn-imagem-excluir").click(function () {
        var CampoHidden = $(this).parent().find("input[name=imagem]");
        var Imagem = $(this).parent().find(".img-upload");

        //Ajax Deletar
        $.ajax({
            type: "GET",
            url: "/Colaborador/Imagem/Deletar?caminho=" + CampoHidden.val(),
            error: function () {

            },
            success: function () {
                Imagem.attr("src", "/img/imagem-padrao.png");
            },
        })
    }); 
    

    //Formulário de dados via JavaScript
    $(".input-file").change(function () {
        var Binario = $(this)[0].files[0];
        var Formulario = new FormData();
        Formulario.append("file", Binario);

        //Rertorna a imagem no campo
        var CampoHidden = $(this).parent().find("input[name=imagem]");
        var Imagem = $(this).parent().find(".img-upload");

        //Requisicao Ajax enviando o Formulário 
        $.ajax({
            type: "POST",
            url: "/Colaborador/Imagem/Armazenar",
            data: Formulario,
            contentType: false,
            processData: false,
            error: function () {
                alert("Erro no envio do arquivo!");
            },
            success: function (data) {
                var caminho = data.caminho;
                Imagem.attr("src", caminho);
                CampoHidden.val(caminho);
            }
        });
    });
}

