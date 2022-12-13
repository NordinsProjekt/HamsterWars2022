async function postAPI(url,args) {
    let result;

    try {
        result = await $.ajax({
            url: url,
            type: 'POST',
            data: args
        });

        return result;
    } catch (error) {
        console.error(error);
    }
}

async function getAPI(url) {
    let result;

    try {
        result = await $.ajax({
            url: url,
            type: 'GET'
        });

        return result;
    } catch (error) {
        console.error(error);
    }
}