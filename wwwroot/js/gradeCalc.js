$("#submitButton").click(
    function () {

        //declare variables and retrieve information from the submitted form
        var assign = parseInt($("#assignments").val());
        var groupProj = parseInt($("#groupProjects").val());
        var quiz = parseInt($("#quizzes").val());
        var exam = parseInt($("#exams").val());
        var intex = parseInt($("#intex").val());

        var finalPerc = assign * .5 + groupProj * .1 + quiz * .1 + exam * .2 + intex * .1;
        var finalGrade;

        //if statement to determine the final grade of the student
        if (finalPerc >= 90) {
            finalGrade = 'A'
        }
        else if (finalPerc >= 80) {
            finalGrade = 'B'
        }
        else if (finalPerc >= 70) {
            finalGrade = 'C'
        }
        else if (finalPerc >= 60) {
            finalGrade = 'D'
        }
        else {
            finalGrade = 'F'
        }

        //display the message with the final percentage and final grade
        alert(`Final Percentage: ${finalPerc} \n Final Grade: ${finalGrade}`);
    });