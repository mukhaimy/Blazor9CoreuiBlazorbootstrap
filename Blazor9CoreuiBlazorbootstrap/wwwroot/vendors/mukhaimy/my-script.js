
window.downloadFileFromStream = async (fileName, contentStreamReference) => {
    const arrayBuffer = await contentStreamReference.arrayBuffer();
    const blob = new Blob([arrayBuffer]);
    const url = URL.createObjectURL(blob);
    const anchorElement = document.createElement('a');
    anchorElement.href = url;
    anchorElement.download = fileName ?? '';
    anchorElement.click();
    anchorElement.remove();
    URL.revokeObjectURL(url);
}

function saveAsFile(filename, bytesBase64) {
    if (navigator.msSaveBlob) {
        //Download document in Edge browser
        var data = window.atob(bytesBase64);
        var bytes = new Uint8Array(data.length);
        for (var i = 0; i < data.length; i++) {
            bytes[i] = data.charCodeAt(i);
        }
        var blob = new Blob([bytes.buffer], { type: "application/octet-stream" });
        navigator.msSaveBlob(blob, filename);
    }
    else {
        var link = document.createElement('a');
        link.download = filename;
        link.href = "data:application/octet-stream;base64," + bytesBase64;
        document.body.appendChild(link); // Needed for Firefox
        link.click();
        document.body.removeChild(link);
    }
}


function addToLocalStorage(key, value) { localStorage[key] = value; }

function readLocalStorage(key) { return localStorage[key]; }

window.methods = {
    CreateCookie: function (name, value, days) {
        var expires;
        if (days) {
            var date = new Date();
            date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
            expires = "; expires=" + date.toGMTString();
        }
        else {
            expires = "";
        }
        document.cookie = name + "=" + value + expires + "; path=/";
    }
} 


/*For SWAL      */
/*--------------*/
function injectScript(url) {
    const script = document.createElement('script');
    script.src = url;
    document.head.appendChild(script);
}

Blazor.addEventListener('enhancedload', () => {
    const oldScript = document.querySelector('script[src="_content/CurrieTechnologies.Razor.SweetAlert2/sweetAlert2.min.js"]');
    if (oldScript) {
        oldScript.remove();
    }

    injectScript('_content/CurrieTechnologies.Razor.SweetAlert2/sweetAlert2.min.js');
});

/* From Core UI */
/*--------------*/
const header = document.querySelector('header.header');

document.addEventListener('scroll', () => {
    if (header) {
        header.classList.toggle('shadow-sm', document.documentElement.scrollTop > 0);
    }
});


/* Clue from other admin template to reduce sidebar error */
/*--------------------------------------------------------*/
document.addEventListener('click', function (event) {
    var target = event.target;

    while (target && target.tagName !== 'A') {
        target = target.parentElement;
    }

    if (target && target.href) {
        event.preventDefault();
        window.location.href = target.href;
    }
});