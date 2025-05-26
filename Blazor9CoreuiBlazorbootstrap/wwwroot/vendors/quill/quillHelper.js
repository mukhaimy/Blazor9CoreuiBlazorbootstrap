/* Base on: ChatGPT Answer */

let quillInstances = {};

window.initQuill = (elementId, dotNetHelper) => {
    const quill = new Quill(`#${elementId}`, {
        theme: 'snow'
    });

    quill.on('text-change', function () {
        dotNetHelper.invokeMethodAsync('UpdateContent', quill.root.innerHTML);
    });

    quillInstances[elementId] = quill;
};

window.setQuillContent = (elementId, content) => {
    if (quillInstances[elementId]) {
        quillInstances[elementId].root.innerHTML = content;
    }
};
