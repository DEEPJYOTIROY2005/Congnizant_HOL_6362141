import React from 'react';
import styles from '../CohortDetails.module.css'; // Update the path if needed

const CohortDetails = ({ name, status, startDate, endDate }) => {
  const headingStyle = {
    color: status === "ongoing" ? "green" : "blue",
  };

  return (
    <div className={styles.box}>
      <h3 style={headingStyle}>{name}</h3>
      <dl>
        <dt>Status:</dt>
        <dd>{status}</dd>
        <dt>Start Date:</dt>
        <dd>{startDate}</dd>
        <dt>End Date:</dt>
        <dd>{endDate}</dd>
      </dl>
    </div>
  );
};

export default CohortDetails;
