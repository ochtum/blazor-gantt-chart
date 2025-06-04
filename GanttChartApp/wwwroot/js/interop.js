window.saveAsFile = (filename, base64) => {
    const link = document.createElement('a');
    link.download = filename;
    link.href = 'data:application/octet-stream;base64,' + base64;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
};
