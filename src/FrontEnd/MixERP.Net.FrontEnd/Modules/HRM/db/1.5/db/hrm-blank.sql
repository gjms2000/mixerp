-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/MixERP.Net.FrontEnd/Modules/HRM/db/1.5/db/src/01.types-domains-tables-and-constraints/tables-and-constraints.sql --<--<--
/********************************************************************************
Copyright (C) MixERP Inc. (http://mixof.org).
This file is part of MixERP.
MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 2 of the License.
MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.
You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/

DROP SCHEMA IF EXISTS hrm CASCADE;
CREATE SCHEMA hrm;

CREATE TABLE hrm.education_levels
(
    education_level_id                      SERIAL NOT NULL PRIMARY KEY,
    education_level_name                    national character varying(50) NOT NULL UNIQUE,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);


CREATE TABLE hrm.employment_status_codes
(
    employment_status_code_id               integer NOT NULL PRIMARY KEY,
    status_code                             national character varying(12) NOT NULL UNIQUE,
    status_code_name                        national character varying(100) NOT NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.employment_statuses
(
    employment_status_id                    SERIAL NOT NULL PRIMARY KEY,
    employment_status_code                  national character varying(12) NOT NULL UNIQUE,
    employment_status_name                  national character varying(100) NOT NULL,
    is_contract                             boolean NOT NULL DEFAULT(false),
    default_employment_status_code_id       integer NOT NULL REFERENCES hrm.employment_status_codes,
    description                             text DEFAULT(''),    
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.job_titles
(
    job_title_id                            SERIAL NOT NULL PRIMARY KEY,
    job_title_code                          national character varying(12) NOT NULL UNIQUE,
    job_title_name                          national character varying(100) NOT NULL,
    description                             text DEFAULT(''),
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.pay_grades
(
    pay_grade_id                            SERIAL NOT NULL PRIMARY KEY,
    pay_grade_code                          national character varying(12) NOT NULL UNIQUE,
    pay_grade_name                          national character varying(100) NOT NULL,
    minimum_salary                          decimal(24, 4) NOT NULL,
    maximum_salary                          decimal(24, 5) NOT NULL
                                            CHECK(maximum_salary >= minimum_salary),
    description                             text DEFAULT(''),
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.shifts
(
    shift_id                            SERIAL NOT NULL PRIMARY KEY,
    shift_code                          national character varying(12) NOT NULL UNIQUE,
    shift_name                          national character varying(100) NOT NULL,
    begins_from                         time NOT NULL,
    ends_on                             time NOT NULL,
    description                         text DEFAULT(''),
    audit_user_id                       integer NULL REFERENCES office.users(user_id),
    audit_ts                            TIMESTAMP WITH TIME ZONE NULL 
                                        DEFAULT(NOW())    
);

CREATE TABLE hrm.leave_types
(
    leave_type_id                           SERIAL NOT NULL PRIMARY KEY,
    leave_type_code                         national character varying(12) NOT NULL UNIQUE,
    leave_type_name                         national character varying(100) NOT NULL,
    description                             text DEFAULT(''),
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.office_hours
(
    office_hour_id                          SERIAL NOT NULL PRIMARY KEY,
    office_id                               integer NOT NULL REFERENCES office.offices(office_id),
    shift_id                                integer NOT NULL REFERENCES hrm.shifts,
    week_day_id                             integer NOT NULL REFERENCES core.week_days(week_day_id),
    begins_from                             time NOT NULL,
    ends_on                                 time NOT NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL    
);

CREATE TABLE hrm.leave_benefits
(
    leave_benefit_id                       SERIAL NOT NULL PRIMARY KEY,
    leave_benefit_code                     national character varying(12) NOT NULL UNIQUE,
    leave_benefit_name                     national character varying(128) NOT NULL,
    total_days                              public.integer_strict NOT NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.employee_types
(
    employee_type_id                        SERIAL NOT NULL PRIMARY KEY,
    employee_type_code                      national character varying(12) NOT NULL UNIQUE,
    employee_type_name                      national character varying(128) NOT NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.employees
(
    employee_id                             SERIAL NOT NULL PRIMARY KEY,
    first_name                              national character varying(50) NOT NULL,
    middle_name                             national character varying(50) DEFAULT(''),
    last_name                               national character varying(50) DEFAULT(''),
    employee_name                           national character varying(160) NOT NULL,
    gender_code                             national character varying(4) NOT NULL 
                                            REFERENCES core.genders(gender_code),
    joined_on                               date NULL,
    office_id                               integer NOT NULL REFERENCES office.offices(office_id),
    user_id                                 integer REFERENCES office.users(user_id),
    employee_type_id                        integer NOT NULL REFERENCES hrm.employee_types(employee_type_id),
    current_department_id                   integer NOT NULL REFERENCES office.departments(department_id),
    current_role_id                         integer REFERENCES office.roles(role_id),
    current_employment_status_id            integer NOT NULL REFERENCES hrm.employment_statuses(employment_status_id),
    current_job_title_id                    integer NOT NULL REFERENCES hrm.job_titles(job_title_id),
    current_pay_grade_id                    integer NOT NULL REFERENCES hrm.pay_grades(pay_grade_id),
    current_shift_id                        integer NOT NULL REFERENCES hrm.shifts(shift_id),
    nationality_code                        national character varying(12) REFERENCES core.nationalities(nationality_code),
    date_of_birth                           date,
    photo                                   public.image,
    zip_code                                national character varying(128) DEFAULT(''),
    address_line_1                          national character varying(128) DEFAULT(''),
    address_line_2                          national character varying(128) DEFAULT(''),
    street                                  national character varying(128) DEFAULT(''),
    city                                    national character varying(128) DEFAULT(''),
    state                                   national character varying(128) DEFAULT(''),    
    country_id                              integer REFERENCES core.countries(country_id),
    phone_home                              national character varying(128) DEFAULT(''),
    phone_cell                              national character varying(128) DEFAULT(''),
    phone_office_extension                  national character varying(128) DEFAULT(''),
    phone_emergency                         national character varying(128) DEFAULT(''),
    phone_emergency2                        national character varying(128) DEFAULT(''),
    email_address                           national character varying(128) DEFAULT(''),
    website                                 national character varying(128) DEFAULT(''),
    blog                                    national character varying(128) DEFAULT(''),
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.employee_identification_details
(
    employee_identification_detail_id       BIGSERIAL NOT NULL PRIMARY KEY,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    identification_type_code                national character varying(12) NOT NULL 
                                            REFERENCES core.identification_types(identification_type_code),
    identification_number                   national character varying(128) NOT NULL,
    expires_on                              date,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())                                          
);

CREATE UNIQUE INDEX employee_identification_details_employee_id_itc_uix
ON hrm.employee_identification_details(employee_id, UPPER(identification_type_code));



CREATE TABLE hrm.employee_social_network_details
(
    employee_social_network_detail_id       BIGSERIAL NOT NULL PRIMARY KEY,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    social_network_name                     national character varying(128) NOT NULL
                                            REFERENCES core.social_networks(social_network_name),
    social_network_id                       national character varying(128) NOT NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.contracts
(
    contract_id                             BIGSERIAL NOT NULL PRIMARY KEY,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    office_id                               integer NOT NULL REFERENCES office.offices(office_id),
    department_id                           integer NOT NULL REFERENCES office.departments(department_id),
    role_id                                 integer REFERENCES office.roles(role_id),
    leave_benefit_id                        integer REFERENCES hrm.leave_benefits(leave_benefit_id),
    began_on                                date,
    ended_on                                date,
    employment_status_code_id               integer NOT NULL REFERENCES hrm.employment_status_codes(employment_status_code_id),
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.salary_frequencies
(
    salary_frequency_id                     integer NOT NULL PRIMARY KEY,
    salary_frequency_name                   national character varying(128) NOT NULL UNIQUE,
    frequency_id                            integer REFERENCES core.frequencies(frequency_id)
);

CREATE TABLE hrm.salary_types
(
    salary_type_id                          SERIAL NOT NULL PRIMARY KEY,
    salary_type_code                        national character varying(12) NOT NULL UNIQUE,
    salary_type_name                        national character varying(128) NOT NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.wages_setup
(
    wages_setup_id                          SERIAL NOT NULL PRIMARY KEY,
    wages_setup_code                        national character varying(12) NOT NULL UNIQUE,
    wages_setup_name                        national character varying(128) NOT NULL,
    currency_code                           national character varying(12) NOT NULL REFERENCES core.currencies(currency_code),
    max_week_hours                          integer NOT NULL DEFAULT(0),
    hourly_rate                             public.money_strict NOT NULL,
    overtime_applicable                     boolean NOT NULL DEFAULT(true),
    overtime_hourly_rate                    public.money_strict2 NOT NULL,
    description                             text,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),
    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);


CREATE TABLE hrm.employee_wages
(
    employee_wage_id                        BIGSERIAL NOT NULL PRIMARY KEY,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    wages_setup_id                          integer NOT NULL REFERENCES hrm.wages_setup(wages_setup_id),
    currency_code                           national character varying(12) NOT NULL REFERENCES core.currencies(currency_code),
    max_week_hours                          integer NOT NULL,
    hourly_rate                             public.money_strict NOT NULL,
    overtime_applicable                     boolean NOT NULL,
    overtime_hourly_rate                    public.money_strict2 DEFAULT(0),
    valid_till                              date NOT NULL,
    is_active                               boolean,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.salaries
(
    salary_id                               BIGSERIAL NOT NULL PRIMARY KEY,    
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    salary_type_id                          integer NOT NULL REFERENCES hrm.salary_types(salary_type_id),
    pay_grade_id                            integer NOT NULL REFERENCES hrm.pay_grades(pay_grade_id),
    salary_frequency_id                     integer NOT NULL REFERENCES hrm.salary_frequencies(salary_frequency_id),
    currency_code                           national character varying(12) NOT NULL REFERENCES core.currencies(currency_code),
    amount                                  public.money_strict NOT NULL,
    deduction_applicable                    boolean NOT NULL DEFAULT(false),
    auto_deduction_based_on_attendance      boolean NOT NULL DEFAULT(false),
    audit_user_id                           integer NULL REFERENCES office.users(user_id),    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);


CREATE TABLE hrm.employee_experiences
(
    employee_experience_id                  BIGSERIAL NOT NULL PRIMARY KEY,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    organization_name                       national character varying(128) NOT NULL,
    title                                   national character varying(128) NOT NULL,
    started_on                              date,
    ended_on                                date,
    details                                 text,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.employee_qualifications
(
    employee_qualification_id               BIGSERIAL NOT NULL PRIMARY KEY,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    education_level_id                      integer NOT NULL REFERENCES hrm.education_levels(education_level_id),
    institution                             national character varying(128) NOT NULL,
    majors                                  national character varying(128) NOT NULL,
    total_years                             integer,
    score                                   numeric,
    started_on                              date,
    completed_on                            date,
    details                                 text,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.holidays
(
    holiday_id                              BIGSERIAL NOT NULL PRIMARY KEY,
    office_id                               integer NOT NULL REFERENCES office.offices(office_id),
    holiday_name                            national character varying(128) NOT NULL,
    occurs_on                               date,
    ends_on                                 date,
    comment                                 text,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.leave_applications
(
    leave_application_id                    BIGSERIAL NOT NULL PRIMARY KEY,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    leave_type_id                           integer NOT NULL REFERENCES hrm.leave_types(leave_type_id),
    entered_by                              integer NOT NULL REFERENCES office.users(user_id),
    applied_on                              date DEFAULT(NOW()),
    reason                                  text,
    start_date                              date,
    end_date                                date,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.resignations
(
    resignation_id                          SERIAL NOT NULL PRIMARY KEY,
    entered_by                              integer NOT NULL REFERENCES office.users(user_id),
    notice_date                             date NOT NULL,
    desired_resign_date                     date NOT NULL,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    forward_to                              integer REFERENCES hrm.employees(employee_id),
    reason                                  national character varying(128) NOT NULL,
    details                                 text,
    verification_status_id                  integer NOT NULL REFERENCES core.verification_statuses(verification_status_id),
    verified_by_user_id                     integer NOT NULL REFERENCES office.users(user_id),
    verified_on                             date NOT NULL,
    effective_resignation_date              date NOT NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.terminations
(
    termination_id                          SERIAL NOT NULL PRIMARY KEY,
    entered_by                              integer NOT NULL REFERENCES office.users(user_id),
    notice_date                             date NOT NULL,
    effective_termination_date              date NOT NULL,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    forward_to                              integer REFERENCES hrm.employees(employee_id),
    reason                                  national character varying(128) NOT NULL,
    details                                 text,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
    
);

CREATE TABLE hrm.exit_types
(
    exit_type_id                            SERIAL NOT NULL PRIMARY KEY,
    exit_type_code                          national character varying(12) NOT NULL UNIQUE,
    exit_type_name                          national character varying(128) NOT NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.exits
(
    exit_id                                 BIGSERIAL NOT NULL PRIMARY KEY,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    change_status_code_to                   integer NOT NULL REFERENCES hrm.employment_status_codes(employment_status_code_id),
    exit_type_id                            integer NOT NULL REFERENCES hrm.exit_types(exit_type_id),
    exit_interview_details                  text,
    reason                                  national character varying(128) NOT NULL,
    details                                 text,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);




-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/MixERP.Net.FrontEnd/Modules/HRM/db/1.5/db/src/03.menus/0.menus.sql --<--<--
--This table should not be localized.
SELECT * FROM core.recreate_menu('HRM', '~/Modules/HRM/Index.mix', 'HRM', 0, NULL);
SELECT * FROM core.recreate_menu('Tasks', NULL, 'HRMTA', 1, core.get_menu_id('HRM'));
SELECT * FROM core.recreate_menu('Attendance', '~/Modules/HRM/Tasks/Attendance.mix', 'ATTNDCE', 2, core.get_menu_id('HRMTA'));
SELECT * FROM core.recreate_menu('Employees', '~/Modules/HRM/Tasks/Employees.mix', 'EMPL', 2, core.get_menu_id('HRMTA'));
SELECT * FROM core.recreate_menu('Contracts', '~/Modules/HRM/Tasks/Contracts.mix', 'CTRCT', 2, core.get_menu_id('HRMTA'));
SELECT * FROM core.recreate_menu('Leave Application', '~/Modules/HRM/Tasks/LeaveApplication.mix', 'LEVAPP', 2, core.get_menu_id('HRMTA'));
SELECT * FROM core.recreate_menu('Resignation', '~/Modules/HRM/Tasks/Resignation.mix', 'RESIGN', 2, core.get_menu_id('HRMTA'));
SELECT * FROM core.recreate_menu('Termination', '~/Modules/HRM/Tasks/Termination.mix', 'TERMIN', 2, core.get_menu_id('HRMTA'));
SELECT * FROM core.recreate_menu('Exit', '~/Modules/HRM/Tasks/Exit.mix', 'EXIT', 2, core.get_menu_id('HRMTA'));

SELECT * FROM core.recreate_menu('Payroll', NULL, 'PAYRL', 1, core.get_menu_id('HRM'));
SELECT * FROM core.recreate_menu('Wages', '~/Modules/HRM/Payroll/Wages.mix', 'WAGES', 2, core.get_menu_id('PAYRL'));
SELECT * FROM core.recreate_menu('Overtime', '~/Modules/HRM/Payroll/Overtime.mix', 'OVERTM', 2, core.get_menu_id('PAYRL'));
SELECT * FROM core.recreate_menu('Deduction', '~/Modules/HRM/Payroll/Deduction.mix', 'OVERTM', 2, core.get_menu_id('PAYRL'));
SELECT * FROM core.recreate_menu('Salary', '~/Modules/HRM/Payroll/Salary.mix', 'SALRY', 2, core.get_menu_id('PAYRL'));
SELECT * FROM core.recreate_menu('Bonus', '~/Modules/HRM/Payroll/Bonus.mix', 'BONUS', 2, core.get_menu_id('PAYRL'));
SELECT * FROM core.recreate_menu('Commissions', '~/Modules/HRM/Payroll/Commissions.mix', 'COMMSN', 2, core.get_menu_id('PAYRL'));


SELECT * FROM core.recreate_menu('Setup & Maintenance', NULL, 'HRMSSM', 1, core.get_menu_id('HRM'));
SELECT * FROM core.recreate_menu('Holiday Setup', '~/Modules/HRM/Setup/HolidaySetup.mix', 'HOLDAY', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Salaries', '~/Modules/HRM/Setup/Salaries.mix', 'SETSAL', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Wages', '~/Modules/HRM/Setup/Wages.mix', 'SETWAGES', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Employment Statuses', '~/Modules/HRM/Setup/EmploymentStatuses.mix', 'EMPSTA', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Employee Types', '~/Modules/HRM/Setup/EmployeeTypes.mix', 'EMPTYP', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Education Levels', '~/Modules/HRM/Setup/EducationLevels.mix', 'EDULVL', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Job Titles', '~/Modules/HRM/Setup/JobTitles.mix', 'JOBTA', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Pay Grades', '~/Modules/HRM/Setup/PayGrades.mix', 'PATGR', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Salary Types', '~/Modules/HRM/Setup/SalaryTypes.mix', 'SALTYP', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Shifts', '~/Modules/HRM/Setup/Shifts.mix', 'SHIFT', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Office Hours', '~/Modules/HRM/Setup/OfficeHours.mix', 'OFFHRS', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Leave Types', '~/Modules/HRM/Setup/LeaveTypes.mix', 'LEVTYP', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Leave Benefits', '~/Modules/HRM/Setup/LeaveBenefits.mix', 'LEVBEN', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('Exit Types', '~/Modules/HRM/Setup/ExitTypes.mix', 'Exit Types', 2, core.get_menu_id('HRMSSM'));
SELECT * FROM core.recreate_menu('HRM Reports', NULL, 'HRMRPT', 1, core.get_menu_id('HRM'));


DELETE FROM policy.menu_access;
INSERT INTO policy.menu_access(office_id, menu_id, user_id)
SELECT office_id, menu_id, 2
FROM office.offices, core.menus;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/MixERP.Net.FrontEnd/Modules/HRM/db/1.5/db/src/04.default-values/01.default-values.sql --<--<--
DO
$$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM core.attachment_lookup WHERE book = 'employee') THEN
        INSERT INTO core.attachment_lookup(book, resource, resource_key)
        SELECT 'employee',           'core.employees',  'employee_id';
    END IF;
END
$$
LANGUAGE plpgsql;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/MixERP.Net.FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.contract_scrud_view.sql --<--<--
DROP VIEW IF EXISTS hrm.contract_scrud_view;

CREATE VIEW hrm.contract_scrud_view
AS
SELECT
    hrm.contracts.contract_id,
    hrm.employees.employee_id,
    office.offices.office_code || ' (' || office.offices.office_name || ')' AS office,
    office.departments.department_code || ' (' || office.departments.department_name || ')' AS department,
    office.roles.role_code || ' (' || office.roles.role_name || ')' AS role,
    hrm.leave_benefits.leave_benefit_code || ' (' || hrm.leave_benefits.leave_benefit_name || ')' AS leave_benefit,
    hrm.employment_status_codes.status_code || ' (' || hrm.employment_status_codes.status_code_name || ')' AS employment_status_code,
    hrm.contracts.began_on,
    hrm.contracts.ended_on
FROM hrm.contracts
INNER JOIN hrm.employees
ON hrm.employees.employee_id = hrm.contracts.employee_id
INNER JOIN office.offices
ON office.offices.office_id = hrm.contracts.office_id
INNER JOIN office.departments
ON office.departments.department_id = hrm.contracts.department_id
INNER JOIN office.roles
ON office.roles.role_id = hrm.contracts.role_id
INNER JOIN hrm.employment_status_codes
ON hrm.employment_status_codes.employment_status_code_id = hrm.contracts.employment_status_code_id
LEFT JOIN hrm.leave_benefits
ON hrm.leave_benefits.leave_benefit_id = hrm.contracts.leave_benefit_id;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/MixERP.Net.FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.employee_experience_scrud_view.sql --<--<--
DROP VIEW IF EXISTS hrm.employee_experience_scrud_view;

CREATE VIEW hrm.employee_experience_scrud_view
AS
SELECT
    hrm.employee_experiences.employee_experience_id,
    hrm.employee_experiences.employee_id,
    hrm.employees.employee_name,
    hrm.employee_experiences.organization_name,
    hrm.employee_experiences.title,
    hrm.employee_experiences.started_on,
    hrm.employee_experiences.ended_on
FROM hrm.employee_experiences
INNER JOIN hrm.employees
ON hrm.employee_experiences.employee_id = hrm.employees.employee_id;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/MixERP.Net.FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.employee_identification_detail_scrud_view.sql --<--<--
DROP VIEW IF EXISTS hrm.employee_identification_detail_scrud_view;

CREATE VIEW hrm.employee_identification_detail_scrud_view
AS
SELECT
    hrm.employee_identification_details.employee_identification_detail_id,
    hrm.employee_identification_details.employee_id,
    hrm.employees.employee_name,
    hrm.employee_identification_details.identification_type_code,
    core.identification_types.identification_type_name,
    hrm.employee_identification_details.identification_number,
    hrm.employee_identification_details.expires_on
FROM hrm.employee_identification_details
INNER JOIN hrm.employees
ON hrm.employee_identification_details.employee_id = hrm.employees.employee_id
INNER JOIN core.identification_types
ON hrm.employee_identification_details.identification_type_code = core.identification_types.identification_type_code;




-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/MixERP.Net.FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.employee_qualification_scrud_view.sql --<--<--
DROP VIEW IF EXISTS hrm.employee_qualification_scrud_view;

CREATE VIEW hrm.employee_qualification_scrud_view
AS
SELECT
    hrm.employee_qualifications.employee_qualification_id,
    hrm.employee_qualifications.employee_id,
    hrm.employees.employee_name,
    hrm.education_levels.education_level_name,
    hrm.employee_qualifications.institution,
    hrm.employee_qualifications.majors,
    hrm.employee_qualifications.total_years,
    hrm.employee_qualifications.score,
    hrm.employee_qualifications.started_on,
    hrm.employee_qualifications.completed_on
FROM hrm.employee_qualifications
INNER JOIN hrm.employees
ON hrm.employee_qualifications.employee_id = hrm.employees.employee_id
INNER JOIN hrm.education_levels
ON hrm.employee_qualifications.education_level_id = hrm.education_levels.education_level_id;



-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/MixERP.Net.FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.employee_social_network_detail_scrud_view.sql --<--<--
DROP VIEW IF EXISTS hrm.employee_social_network_detail_scrud_view;

CREATE VIEW hrm.employee_social_network_detail_scrud_view
AS
SELECT
    hrm.employee_social_network_details.employee_social_network_detail_id,
    hrm.employee_social_network_details.employee_id,
    hrm.employees.employee_name,
    hrm.employee_social_network_details.social_network_name,
    hrm.employee_social_network_details.social_network_id,
    core.social_networks.semantic_css_class,
    core.social_networks.base_url,
    core.social_networks.profile_url
FROM hrm.employee_social_network_details
INNER JOIN hrm.employees
ON hrm.employee_social_network_details.employee_id = hrm.employees.employee_id
INNER JOIN core.social_networks
ON core.social_networks.social_network_name = hrm.employee_social_network_details.social_network_name;



-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/MixERP.Net.FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.employee_wage_scrud_view.sql --<--<--
DROP VIEW IF EXISTS hrm.employee_wage_scrud_view;

CREATE VIEW hrm.employee_wage_scrud_view
AS
SELECT
    hrm.employee_wages.employee_wage_id,
    hrm.employees.employee_name,
    hrm.wages_setup.wages_setup_code || ' (' || hrm.wages_setup.wages_setup_name || ')' AS wages_setup,
    hrm.employee_wages.currency_code,
    hrm.employee_wages.max_week_hours,
    hrm.employee_wages.hourly_rate,
    hrm.employee_wages.overtime_applicable,
    hrm.employee_wages.overtime_hourly_rate,
    hrm.employee_wages.valid_till,
    hrm.employee_wages.is_active
FROM hrm.employee_wages
INNER JOIN hrm.employees
ON hrm.employee_wages.employee_id = hrm.employees.employee_id
INNER JOIN hrm.wages_setup
ON hrm.wages_setup.wages_setup_id = hrm.employee_wages.wages_setup_id;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/MixERP.Net.FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.exit_scrud_view.sql --<--<--
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





-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/MixERP.Net.FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.leave_application_scrud_view.sql --<--<--
DROP VIEW IF EXISTS hrm.leave_application_scrud_view;

CREATE VIEW hrm.leave_application_scrud_view
AS
SELECT
    hrm.leave_applications.leave_application_id,
    hrm.employees.employee_name,
    hrm.leave_types.leave_type_code || ' (' || hrm.leave_types.leave_type_name || ')' AS leave_type,
    office.users.user_name AS entered_by,
    hrm.leave_applications.applied_on,
    hrm.leave_applications.reason,
    hrm.leave_applications.start_date,
    hrm.leave_applications.end_date
FROM hrm.leave_applications
INNER JOIN hrm.employees
ON hrm.employees.employee_id = hrm.leave_applications.employee_id
INNER JOIN hrm.leave_types
ON hrm.leave_types.leave_type_id = hrm.leave_applications.leave_type_id
INNER JOIN office.users
ON office.users.user_id = hrm.leave_applications.entered_by;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/MixERP.Net.FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.office_hour_scrud_view.sql --<--<--
DROP VIEW IF EXISTS hrm.office_hour_scrud_view;

CREATE VIEW hrm.office_hour_scrud_view
AS
SELECT
    hrm.office_hours.office_hour_id,
    office.offices.office_code || ' (' || office.offices.office_name || ')' AS office,
    hrm.shifts.shift_code || ' (' || hrm.shifts.shift_name || ')' AS shift,
    core.week_days.week_day_code || ' (' || core.week_days.week_day_name || ')' AS week_day,
    hrm.office_hours.begins_from,
    hrm.office_hours.ends_on
FROM hrm.office_hours
INNER JOIN office.offices
ON office.offices.office_id = hrm.office_hours.office_id
INNER JOIN hrm.shifts
ON hrm.shifts.shift_id = hrm.office_hours.shift_id
INNER JOIN core.week_days
ON core.week_days.week_day_id = hrm.office_hours.week_day_id;




-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/MixERP.Net.FrontEnd/Modules/HRM/db/1.5/db/src/05.scrud-views/hrm.termination_scrud_view.sql --<--<--
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

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/MixERP.Net.FrontEnd/Modules/HRM/db/1.5/db/src/05.views/hrm.employee_view.sql --<--<--
DROP VIEW IF EXISTS hrm.employee_view;

CREATE VIEW hrm.employee_view
AS
SELECT
    hrm.employees.employee_id,
    hrm.employees.first_name,
    hrm.employees.middle_name,
    hrm.employees.last_name,
    hrm.employees.employee_name,
    hrm.employees.gender_code,
    core.genders.gender_name,
    hrm.employees.joined_on,
    hrm.employees.office_id,
    office.offices.office_code || ' (' || office.offices.office_name || ')' AS office,
    hrm.employees.user_id,
    office.users.user_name,
    hrm.employees.employee_type_id,
    hrm.employee_types.employee_type_code || ' (' || hrm.employee_types.employee_type_name || ')' AS employee_type,
    hrm.employees.current_department_id,
    office.departments.department_code || ' (' || office.departments.department_name || ')' AS current_department,    
    hrm.employees.current_role_id,
    office.roles.role_code || ' (' || office.roles.role_name || ')' AS role,
    hrm.employees.current_employment_status_id,
    hrm.employment_statuses.employment_status_code || ' (' || employment_status_name || ')' AS employment_status,
    hrm.employees.current_job_title_id,
    hrm.job_titles.job_title_code || ' (' || hrm.job_titles.job_title_name || ')' AS job_title,
    hrm.employees.current_pay_grade_id,
    hrm.pay_grades.pay_grade_code || ' (' || hrm.pay_grades.pay_grade_name || ')' AS pay_grade,
    hrm.employees.current_shift_id,
    hrm.shifts.shift_code || ' (' || hrm.shifts.shift_name || ')' AS shift,
    hrm.employees.nationality_code,
    core.nationalities.nationality_code || ' (' || core.nationalities.nationality_name || ')' AS nationality,
    hrm.employees.date_of_birth,
    hrm.employees.photo,
    hrm.employees.zip_code,
    hrm.employees.address_line_1,
    hrm.employees.address_line_2,
    hrm.employees.street,
    hrm.employees.city,
    hrm.employees.state,
    hrm.employees.country_id,
    core.countries.country_name AS country,
    hrm.employees.phone_home,
    hrm.employees.phone_cell,
    hrm.employees.phone_office_extension,
    hrm.employees.phone_emergency,
    hrm.employees.phone_emergency2,
    hrm.employees.email_address,
    hrm.employees.website,
    hrm.employees.blog
FROM hrm.employees
INNER JOIN core.genders
ON hrm.employees.gender_code = core.genders.gender_code
INNER JOIN office.offices
ON hrm.employees.office_id = office.offices.office_id
INNER JOIN office.departments
ON hrm.employees.current_department_id = office.departments.department_id
INNER JOIN hrm.employee_types
ON hrm.employee_types.employee_type_id = hrm.employees.employee_type_id
INNER JOIN hrm.employment_statuses
ON hrm.employees.current_employment_status_id = hrm.employment_statuses.employment_status_id
INNER JOIN hrm.job_titles
ON hrm.employees.current_job_title_id = hrm.job_titles.job_title_id
INNER JOIN hrm.pay_grades
ON hrm.employees.current_pay_grade_id = hrm.pay_grades.pay_grade_id
INNER JOIN hrm.shifts
ON hrm.employees.current_shift_id = hrm.shifts.shift_id
LEFT JOIN office.users
ON hrm.employees.user_id = office.users.user_id
LEFT JOIN office.roles
ON hrm.employees.current_role_id = office.roles.role_id
LEFT JOIN core.nationalities
ON hrm.employees.nationality_code = core.nationalities.nationality_code
LEFT JOIN core.countries
ON hrm.employees.country_id = core.countries.country_id;

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/MixERP.Net.FrontEnd/Modules/HRM/db/1.5/db/src/99.ownership.sql --<--<--
DO
$$
    DECLARE this record;
BEGIN
    IF(CURRENT_USER = 'mix_erp') THEN
        RETURN;
    END IF;

    FOR this IN 
    SELECT * FROM pg_tables 
    WHERE NOT schemaname = ANY(ARRAY['pg_catalog', 'information_schema'])
    AND tableowner <> 'mix_erp'
    LOOP
        EXECUTE 'ALTER TABLE '|| this.schemaname || '.' || this.tablename ||' OWNER TO mix_erp;';
    END LOOP;
END
$$
LANGUAGE plpgsql;

DO
$$
    DECLARE this record;
BEGIN
    IF(CURRENT_USER = 'mix_erp') THEN
        RETURN;
    END IF;

    FOR this IN 
    SELECT 'ALTER '
        || CASE WHEN p.proisagg THEN 'AGGREGATE ' ELSE 'FUNCTION ' END
        || quote_ident(n.nspname) || '.' || quote_ident(p.proname) || '(' 
        || pg_catalog.pg_get_function_identity_arguments(p.oid) || ') OWNER TO mix_erp;' AS sql
    FROM   pg_catalog.pg_proc p
    JOIN   pg_catalog.pg_namespace n ON n.oid = p.pronamespace
    WHERE  NOT n.nspname = ANY(ARRAY['pg_catalog', 'information_schema'])
    LOOP        
        EXECUTE this.sql;
    END LOOP;
END
$$
LANGUAGE plpgsql;


DO
$$
    DECLARE this record;
BEGIN
    IF(CURRENT_USER = 'mix_erp') THEN
        RETURN;
    END IF;

    FOR this IN 
    SELECT * FROM pg_views
    WHERE NOT schemaname = ANY(ARRAY['pg_catalog', 'information_schema'])
    AND viewowner <> 'mix_erp'
    LOOP
        EXECUTE 'ALTER VIEW '|| this.schemaname || '.' || this.viewname ||' OWNER TO mix_erp;';
    END LOOP;
END
$$
LANGUAGE plpgsql;


DO
$$
    DECLARE this record;
BEGIN
    IF(CURRENT_USER = 'mix_erp') THEN
        RETURN;
    END IF;

    FOR this IN 
    SELECT 'ALTER SCHEMA ' || nspname || ' OWNER TO mix_erp;' AS sql FROM pg_namespace
    WHERE nspname NOT LIKE 'pg_%'
    AND nspname <> 'information_schema'
    LOOP
        EXECUTE this.sql;
    END LOOP;
END
$$
LANGUAGE plpgsql;



DO
$$
    DECLARE this record;
BEGIN
    IF(CURRENT_USER = 'mix_erp') THEN
        RETURN;
    END IF;

    FOR this IN 
    SELECT      'ALTER TYPE ' || n.nspname || '.' || t.typname || ' OWNER TO mix_erp;' AS sql
    FROM        pg_type t 
    LEFT JOIN   pg_catalog.pg_namespace n ON n.oid = t.typnamespace 
    WHERE       (t.typrelid = 0 OR (SELECT c.relkind = 'c' FROM pg_catalog.pg_class c WHERE c.oid = t.typrelid)) 
    AND         NOT EXISTS(SELECT 1 FROM pg_catalog.pg_type el WHERE el.oid = t.typelem AND el.typarray = t.oid)
    AND         typtype NOT IN ('b')
    AND         n.nspname NOT IN ('pg_catalog', 'information_schema')
    LOOP
        EXECUTE this.sql;
    END LOOP;
END
$$
LANGUAGE plpgsql;
