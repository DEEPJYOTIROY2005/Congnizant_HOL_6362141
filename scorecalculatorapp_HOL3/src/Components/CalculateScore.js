import React from 'react';
import '../Stylesheets/mystyle.css';

function CalculateScore() {
  const name = "John Doe";
  const school = "ABC High School";
  const totalMarks = 450;
  const goalMarks = 500;
  const average = (totalMarks / goalMarks) * 100;

  return (
    <div className="score-container">
      <h2>Student Score Details</h2>
      <p><strong>Name:</strong> {name}</p>
      <p><strong>School:</strong> {school}</p>
      <p><strong>Total Marks:</strong> {totalMarks}</p>
      <p><strong>Goal Marks:</strong> {goalMarks}</p>
      <p><strong>Average Score:</strong> {average.toFixed(2)}%</p>
    </div>
  );
}

export default CalculateScore;
