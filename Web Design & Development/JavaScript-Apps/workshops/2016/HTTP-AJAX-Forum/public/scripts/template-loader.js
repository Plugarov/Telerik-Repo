const templateLoader = (() => {

    function get(templateName) {
        return new Promise((resolve, reject) => {
            $.get(`/scripts/templates/${templateName}.handlebars`)
                .then((data) => {
                    let template = Handlebars.compile(data);
                    resolve(template);
                })
                .fail(reject)
        })
    }

    return {
        get
    }
})()

export { templateLoader };