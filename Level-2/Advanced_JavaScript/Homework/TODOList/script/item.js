var todoList = todoList || {};

(function (scope){
    'use strict';
    var id = 0;

    function Item(content){
        this._id = id + 1;
        this.content = content;
        this.isCompleted = false;
        id++;
    }

    Item.prototype.addToDOM = function addToDOM(parrentId){
        var currentSection = document.getElementById(parrentId);
        var sectionFooter = currentSection.getElementsByTagName('footer')[0];
        var newItemDiv = document.createElement('div');
        newItemDiv.setAttribute('id', this._id);

        var checkBox = document.createElement('input');
        checkBox.setAttribute('type', 'checkbox');
        newItemDiv.appendChild(checkBox);

        checkBox.addEventListener('change', function(ev){
            if(this.checked){
                this.nextElementSibling.style.backgroundColor = 'lightgreen';
            }else {
                this.nextElementSibling.style.backgroundColor = '';
            }
        });

        var content = document.createElement('span');
        content.innerText = this.content;
        newItemDiv.appendChild(content);

        var hr = document.createElement('hr');
        newItemDiv.appendChild(hr);

        currentSection.insertBefore(newItemDiv, sectionFooter);
    }

    scope.newItem = function newItem(content){
        return new Item(content);
    }
}(todoList));
