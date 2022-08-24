


function GetUserList(url) {
    $.get(url, function (response) {
        document.getElementById('userListHere').innerHTML = response;
    }) 
}
