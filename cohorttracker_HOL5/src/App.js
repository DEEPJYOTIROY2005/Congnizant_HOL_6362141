import React from "react";
import CohortDetails from "./CohortDetails";

function App() {
  return (
    <div>
      <CohortDetails name="React Bootcamp" status="ongoing" duration="4 weeks" />
      <CohortDetails name="Node.js Basics" status="completed" duration="6 weeks" />
    </div>
  );
}

export default App;
