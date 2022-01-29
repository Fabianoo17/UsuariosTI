function getParameterByName(name, url) {
    if (!url) url = window.location.href;
    name = name.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, " "));
}

function validaCampos(valida) {
    if (valida > 0) {
        Swal.fire({
            type: 'error',
            title: "",
            text: 'Favor preencher os campos em destaque.',
            showConfirmButton: false,
            timer: 2500
        });
        return false;
    }
}

