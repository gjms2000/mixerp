DROP VIEW IF EXISTS hrm.exit_scrud_view;

CREATE VIEW hrm.exit_scrud_view
AS
SELECT
    hrm.exits.exit_id,
    hrm.exits.employee_id,
    hrm.employees.employee_name,
    hrm.exits.reason,
    hrm.employment_status_codes.status_code || ' (' || hrm.employment_status_codes.status_code_name || ')' AS employment_status_code,
    hrm.exit_types.exit_type_code || ' (' || hrm.exit_types.exit_type_name || ')' AS exit_type,
    hrm.exits.details,
    hrm.exits.exit_interview_details
FROM hrm.exits
INNER JOIN hrm.employees
ON hrm.employees.employee_id = hrm.exits.employee_id
INNER JOIN hrm.employment_status_codes
ON hrm.employment_status_codes.employment_status_code_id = hrm.exits.change_status_code_to
INNER JOIN hrm.exit_types
ON hrm.exit_types.exit_type_id = hrm.exits.exit_type_id;



