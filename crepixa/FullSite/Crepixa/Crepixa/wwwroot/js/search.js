var tags = [], res = [], tags_res = [], idx = -1;
var options_list = document.getElementById('result_list');

// here select tags
document.getElementById('search').addEventListener('keyup', function (e) {
    let val = e.target.value;
    switch (e.keyCode) {
        case 38:
            idx = idx < 0 ? 0 : idx;
            options_list.children[idx].style.color = 'black';
            idx = (idx - 1 + res.length) % res.length;
            options_list.children[idx].style.color = 'red';
            console.log(res[idx]);
            break;
        case 40:
            options_list.children[idx < 0 ? 0 : idx].style.color = 'black';
            idx = (idx + 1) % res.length;
            options_list.children[idx].style.color = 'red';
            console.log(res[idx]);
            break;
        case 13:
            if (res.length == 0 || idx < 0) {
                document.getElementById('search').value = '';
                break;
            }
            tags_res.push(res[idx]);
            create_item(res[idx]);
            res = []; options_list.innerHTML = '';
            document.getElementById('search').value = '';
            break;
        default:
            idx = -1;
            res = [];
            for (let i = 0; i < tags.length && val != null && val.length > 0; i++)
                if (tags[i].toLowerCase().includes(val.toLowerCase()))
                    res.push(tags[i]);
            option_list();
            break;
    }
});

function create_item(val) {
    var list_group = document.getElementById('ul_group');
    var list_item = document.createElement('li');
    list_item.className = 'list-group-item';
    list_item.style.color = 'black';
    list_item.innerHTML = val;
    list_group.appendChild(list_item);
}

function option_list() {
    options_list.innerHTML = '';
    for (let i = 0; i < res.length; i++) {
        options_list.innerHTML += `<li class = 'list-group-item'> ${res[i]} </li>`;
    }
    console.log(options_list);
    set_position();
}

function set_position() {
    let srch = document.getElementById('search');
    let pnl = document.getElementById('pnldiv');
    pnl.style.top = srch.clientHeight + 'px';
    pnl.style.left = 0 + 'px';
    pnl.style.zIndex = 2;
    //console.log(top);
}