import React from 'react';
import CohortDetails from './components/CohortDetails';

function App() {
  return (
    <div>
      <CohortDetails
        name="React Cohort"
        status="ongoing"
        startDate="01-Jul-2025"
        endDate="31-Aug-2025"
      />
      <CohortDetails
        name="Java Cohort"
        status="completed"
        startDate="01-May-2025"
        endDate="30-Jun-2025"
      />
    </div>
  );
}

export default App;
