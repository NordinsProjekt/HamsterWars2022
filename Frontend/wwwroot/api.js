async function postAPI(url,args) {
    let result;

    try {
        result = await $.ajax({
            url: url,
            method: 'POST',
            data: JSON.stringify(args),
            contentType: 'application/json'
        });
        return result;
    } catch (error) {
        console.error(error);
        
    }
}

async function postVoidAPI(url) {
    let result;

    try {
        result = await $.ajax({
            url: url,
            method: 'POST',
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

async function delAPI(url) {
    let result;

    try {
        result = await $.ajax({
            url: url,
            method: 'DELETE'
        });

        return result;
    } catch (error) {
        console.error(error);
    }
}

function OnScrollEvent() {
    document.documentElement.scrollTop = 0;
}