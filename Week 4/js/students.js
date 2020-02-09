var studentData = '{"students": [{"id": "Steve", "email": "stevemail@yahoo.com"}, {"id": "jason", "email": "friday13@yahoo.com"}]}'

function ParseStudents(){
    return JSON.parse(studentData).students;
}

function DisplayStudents(students) {
    var tableList = "";
    for(i = 0; i < students.length; i++) {
        var studentId = students[i].id;
        var studentEmail = students[i].email;
        tableList += "<tr><td>" + studentId + "</td><td>" + studentEmail + "</td>";
    }
    document.getElementById("student-list").innerHTML = tableList;  
}

function BuildTable(){
    DisplayStudents(ParseStudents());
}