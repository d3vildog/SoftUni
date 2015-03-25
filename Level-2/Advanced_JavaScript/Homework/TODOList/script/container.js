var todoList = todoList || {};

(function(scope){
    'use strict';
    function Container(){
        this._sections = [];
    };

    Container.prototype.addToDOM = function addToDOM(){
        var sectionsDiv = document.createElement("main");
        var todoFooter = document.getElementById('todo-footer');
        var todolist = document.getElementById('todolist');
        todolist.insertBefore(sectionsDiv, todoFooter);

        var newSectionBtn = document.getElementById('btnNewSection');
        newSectionBtn.addEventListener("click", function(ev){
            var sectionTitle = document.getElementById('newSection-title').value;
            var noNo;

            if(!sectionTitle){
                noNo = document.createElement('div');
                noNo.innerText = 'Title cannot be NULL!';
                noNo.style.color = "red";
                noNo.setAttribute('id', 'no');

                var a = setInterval(function(){
                    document.getElementById('newSection-title').setAttribute('required', 'required');
                    document.getElementById('newSection-title').style.borderColor = 'red';
                    if(noNo != ""){
                        todoFooter.appendChild(noNo);
                    };
                });

                setTimeout(function(){
                    document.getElementById('newSection-title').style.borderColor = 'initial';
                    todoFooter.removeChild(noNo);
                    clearInterval(a);
                }, 2000);
            } else {
                var newSection = todoList.newSection(sectionTitle);
                newSection.addToDOM();

                document.getElementById('newSection-title').value = "";
            }
        });
    };

    scope.newContainer = function newContainer(){
        return new Container();
    };
}(todoList));
