DROP VIEW IF EXISTS hrm.termination_scrud_view;

CREATE VIEW hrm.termination_scrud_view
AS
SELECT
    hrm.terminations.termination_id,
    office.users.user_name AS entered_by,
    hrm.employees.employee_name,
    hrm.terminations.notice_date,
    hrm.terminations.effective_termination_date,
    forwarded_to.employee_name AS forward_to,
    hrm.terminations.reason,
    hrm.terminations.details
FROM hrm.terminations
INNER JOIN hrm.employees
ON hrm.employees.employee_id = hrm.terminations.employee_id
INNER JOIN hrm.employees AS forwarded_to
ON forwarded_to.employee_id = hrm.terminations.forward_to
INNER JOIN office.users
ON office.users.user_id = hrm.terminations.entered_by;