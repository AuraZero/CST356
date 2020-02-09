var instructorData = '{"instructors": [{"firstname": "Steve", "lastname": "Rogers", "age":93}, {"firstname": "Tony", "lastname": "Stark", "age":48}]}'

function ParseInstructors(){
    return JSON.parse(instructorData).instructors;
}

function DisplayInstructors(instructors) {
    var tableList = "";
    for(i = 0; i < instructors.length; i++) {
        var instructorFirstname = instructors[i].firstname;
        var instructorLastname = instructors[i].lastname
        var instructorAge = instructors[i].age;
        tableList += "<tr><td>" + instructorFirstname + "</td><td>" + instructorLastname + "</td><td>" + instructorAge + "</td></tr>";
    }
    document.getElementById("instructor-list").innerHTML = tableList;  
}

function BuildTable(){
    DisplayInstructors(ParseInstructors());
}