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
    week_day_id                             integer NOT NULL PRIMARY KEY,
    office_id                               integer NOT NULL REFERENCES office.offices(office_id),
    shift_id                                integer NOT NULL REFERENCES hrm.shifts,
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
    gender_code                             character(2) NOT NULL REFERENCES core.genders(gender_code),
    joined_on                               date NULL,
    office_id                               integer NOT NULL REFERENCES office.offices(office_id),
    user_id                                 integer REFERENCES office.users(user_id),
    employee_type_id                        integer NOT NULL REFERENCES hrm.employee_types(employee_type_id),
    current_department_id                   integer NOT NULL REFERENCES office.departments(department_id),
    current_role_id                         integer REFERENCES office.roles(role_id),
    current_employment_status_id            integer NOT NULL REFERENCES hrm.employment_statuses(employment_status_id),
    current_job_title_id                    integer NOT NULL REFERENCES hrm.employment_statuses(employment_status_id),
    current_pay_grade_id                    integer NOT NULL REFERENCES hrm.pay_grades(pay_grade_id),
    current_shift_id                        integer NOT NULL REFERENCES hrm.shifts(shift_id),
    nationality_code                        national character varying(12) REFERENCES core.nationalities(nationality_code),
    date_of_birth                           date,
    photo                                   image,
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
    identification_number                   text,
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
    social_network_id                       text,
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


--Todo
CREATE TABLE hrm.salary_frequencies
(
    salary_frequency_id                     integer NOT NULL PRIMARY KEY
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

CREATE TABLE hrm.salaries
(
    salary_id                               BIGINT NOT NULL PRIMARY KEY,    
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
    employee_experience_id                  BIGINT NOT NULL PRIMARY KEY,
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
    employee_qualification_id               BIGINT NOT NULL PRIMARY KEY,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    education_level_id                      integer NOT NULL REFERENCES hrm.education_levels(education_level_id),
    institution                             national character varying(128) NOT NULL,
    majors                                  national character varying(128) NOT NULL,
    total_years                             integer,
    score                                   numeric,
    started_on                              date,
    completed_on                            date,
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

CREATE TABLE hrm.leave_application
(
    leave_application_id                    BIGINT NOT NULL PRIMARY KEY,
    employee_id                             integer NOT NULL REFERENCES hrm.employees(employee_id),
    leave_type_id                           integer NOT NULL REFERENCES hrm.leave_types(leave_type_id),
    entered_by                              integer NOT NULL REFERENCES office.users(user_id),
    applied_on                              date,
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
    effecive_resignation_date               date NOT NULL,
    audit_user_id                           integer NULL REFERENCES office.users(user_id),    
    audit_ts                                TIMESTAMP WITH TIME ZONE NULL 
                                            DEFAULT(NOW())    
);

CREATE TABLE hrm.terminations
(
    termination_id                          SERIAL NOT NULL PRIMARY KEY,
    entered_by                              integer NOT NULL REFERENCES office.users(user_id),
    notice_date                             date NOT NULL,
    effecive_termination_date               date NOT NULL,
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
SELECT * FROM core.recreate_menu('Resignation', '~/Modules/HRM/Tasks/Regignation.mix', 'RESIGN', 2, core.get_menu_id('HRMTA'));
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
    core.countries.country_code || ' (' || core.countries.country_name || ')' AS country,
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

-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/FrontEnd/MixERP.Net.FrontEnd/Modules/HRM/db/1.5/db/src/99.regional-data/Retail Industry.sample --<--<--
-->-->-- C:/Users/nirvan/Desktop/mixerp/0. GitHub/src/Modules/HRM/db/1.5/db/src/01.types-domains-tables-and-constraints/tables-and-constraints.sql --<--<--
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

--The meaning of the following should not change
INSERT INTO hrm.employment_status_codes
SELECT -7, 'DEC', 'Deceased'                UNION ALL
SELECT -6, 'DEF', 'Defaulter'               UNION ALL
SELECT -5, 'TER', 'Terminated'              UNION ALL
SELECT -4, 'RES', 'Resigned'                UNION ALL
SELECT -3, 'EAR', 'Early Retirement'        UNION ALL
SELECT -2, 'RET', 'Normal Retirement'       UNION ALL
SELECT -1, 'CPO', 'Contract Period Over'    UNION ALL
SELECT  0, 'NOR', 'Normal Employment'       UNION ALL
SELECT  1, 'OCT', 'On Contract'             UNION ALL
SELECT  2, 'PER', 'Permanent Job'           UNION ALL
SELECT  3, 'RTG', 'Retiring';

INSERT INTO hrm.employment_statuses(employment_status_code, employment_status_name, default_employment_status_code_id, is_contract)
SELECT 'EMP', 'Employee',       0, false UNION ALL
SELECT 'INT', 'Intern',         1, true UNION ALL
SELECT 'CON', 'Contract Basis', 1, true UNION ALL
SELECT 'PER', 'Permanent',      2, false;

INSERT INTO hrm.job_titles(job_title_code, job_title_name)
SELECT 'INT', 'Internship'                      UNION ALL
SELECT 'DEF', 'Default'                         UNION ALL
SELECT 'EXC', 'Executive'                       UNION ALL
SELECT 'MAN', 'Manager'                         UNION ALL
SELECT 'GEM', 'General Manager'                 UNION ALL
SELECT 'BME', 'Board Member'                    UNION ALL
SELECT 'CEO', 'Chief Executive Officer'         UNION ALL
SELECT 'CTO', 'Chief Technology Officer';

INSERT INTO hrm.pay_grades(pay_grade_code, pay_grade_name, minimum_salary, maximum_salary)
SELECT 'L-1', 'Level 1', 0, 0;

INSERT INTO hrm.shifts(shift_code, shift_name, begins_from, ends_on)
SELECT 'MOR', 'Morning Shift',  '6:00'::time,   '14:00'::time   UNION ALL
SELECT 'DAY', 'Day Shift',      '14:00',        '20:00'         UNION ALL
SELECT 'NIT', 'Night Shift',    '20:00',        '6:00';

INSERT INTO hrm.employee_types(employee_type_code, employee_type_name)
SELECT 'DEF', 'Default' UNION ALL
SELECT 'OUE', 'Outdoor Employees' UNION ALL
SELECT 'PRO', 'Project Employees' UNION ALL
SELECT 'SUP', 'Support Staffs' UNION ALL
SELECT 'ENG', 'Engineers';

INSERT INTO hrm.salary_types(salary_type_code, salary_type_name)
SELECT 'BAS', 'Basic Salary' UNION
SELECT 'OTS', 'Overtime Salary' UNION ALL
SELECT 'COM', 'Commision' UNION ALL
SELECT 'EBE', 'Employee Benefits';

INSERT INTO hrm.leave_types(leave_type_code, leave_type_name)
SELECT 'NOR', 'Normal' UNION ALL
SELECT 'EME', 'Emergency' UNION ALL
SELECT 'ILL', 'Illness';

INSERT INTO hrm.exit_types(exit_type_code, exit_type_name)
SELECT 'COE', 'Contract Period Over' UNION ALL
SELECT 'RET', 'Retirement' UNION ALL
SELECT 'RES', 'Resignation' UNION ALL
SELECT 'TER', 'Termination' UNION ALL
SELECT 'DEC', 'Deceased';

