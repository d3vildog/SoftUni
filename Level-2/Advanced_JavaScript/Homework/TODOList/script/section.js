var todoList = todoList || {};

(function (scope){
    'use strict';
    var id = 0;

    function Section(title){
        this._id = id + 1 + "sec";
        this.title = title;
        this.items = [];
        id++;
    }

    Section.prototype.addToDOM = function addToDOM(){
        var _this = this;
        var main = document.getElementsByTagName('main')[0];
        var newSection = document.createElement('section');
        newSection.setAttribute('id', this._id);
        newSection.setAttribute('class', 'nice');

        var currentSectionTitle = document.createElement('h2');
        currentSectionTitle.innerText = this.title;
        newSection.appendChild(currentSectionTitle);

        var sectionFooter = document.createElement('footer');
        var inputItem = document.createElement('input');
        inputItem.setAttribute('type', 'text');
        inputItem.setAttribute('placeholder', 'Add item...');
        sectionFooter.appendChild(inputItem);

        var btnNewItem = document.createElement('button');
        btnNewItem.innerText = '+';
        sectionFooter.appendChild(btnNewItem);
        newSection.appendChild(sectionFooter);

        btnNewItem.addEventListener('click', function(ev){
            if(!inputItem.value){
                var noNo = document.createElement('div');
                noNo.innerText = 'Content cannot be NULL!';
                noNo.style.color = "red";
                noNo.setAttribute('id', 'no');

                var a = setInterval(function(){
                    inputItem.setAttribute('required', 'required');
                    inputItem.style.borderColor = 'red';
                    sectionFooter.appendChild(noNo);
                });

                setTimeout(function(){
                    inputItem.style.borderColor = 'initial';
                    sectionFooter.removeChild(noNo);
                    clearInterval(a);
                }, 2000);
            }else {
                var itemDiv = document.createElement('div');
                var newItem = todoList.newItem(inputItem.value);
                newItem.addToDOM(_this._id);

                inputItem.value = '';
            }
        });

        main.appendChild(newSection);
    }

    scope.newSection = function newSection(title){
        return new Section(title);
    }
}(todoList));
