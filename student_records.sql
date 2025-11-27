DROP DATABASE IF EXISTS student_records;

CREATE DATABASE student_records;
USE student_records;

-- Create students table 
CREATE TABLE students (
    student_id VARCHAR(20) PRIMARY KEY,
    full_name VARCHAR(100) NOT NULL,
    program VARCHAR(100) NOT NULL,
    year_level VARCHAR(20) NOT NULL,
    section VARCHAR(20) NOT NULL,
    status VARCHAR(20) NOT NULL,
    email VARCHAR(100) NOT NULL,
    phone_number VARCHAR(20) NOT NULL,
    address TEXT NOT NULL,
    photo_path VARCHAR(255) 
);

-- Insert student records to student table
INSERT INTO students (student_id, full_name, program, year_level, section, status, email, phone_number, address, photo_path)
VALUES ('2300001', 'Udtohan, Francis Matsubuto', 'Bachelor of Science in Information Technology', '3rd Year', '3IT-D', 'Enrolled', 'baiNaBaiFrancis@gmail.com', '091237459325', 'Blk 32 Lot 32 Phase 5 Southville 1 Brgy. Marinig Cabuyao City Laguna', 'bai.png'),
	   ('2300002', 'Polgoso, Rigor', 'Bachelor of Science in Information Technology', '3rd Year', '3IT-D', 'Enrolled', 'rigor.polgoso@gmail.com', '091234567890', 'Blk 10 Lot 5 Phase 3 Brgy. Banay-Banay Cabuyao City Laguna', 'polgoso.png'),
	   ('2300003', 'Garcia, John Carlo', 'Bachelor of Science in Information Technology', '3rd Year', '3IT-D', 'Enrolled', 'john.garcia@gmail.com', '091298765432', 'Blk 15 Lot 8 Phase 2 Brgy. Mamatid Cabuyao City Laguna', 'john.png'),
	   ('2300004', 'Santos, Maria Isabel', 'Bachelor of Science in Information Technology', '3rd Year', '3IT-D', 'Enrolled', 'maria.santos@gmail.com', '091212345678', 'Blk 20 Lot 12 Phase 4 Brgy. Marinig Cabuyao City Laguna', 'maria.png'),
	   ('2300005', 'Dela Cruz, Mark Anthony', 'Bachelor of Science in Information Technology', '3rd Year', '3IT-D', 'Enrolled', 'mark.delacruz@gmail.com', '091276543210', 'Blk 25 Lot 18 Phase 5 Brgy. Banlic Cabuyao City Laguna', 'mark.png'),
	   ('2300006', 'Lopez, Kristine Joy', 'Bachelor of Science in Information Technology', '3rd Year', '3IT-D', 'Enrolled', 'kristine.lopez@gmail.com', '091234123456', 'Blk 30 Lot 22 Phase 1 Brgy. Pulo Cabuyao City Laguna', 'kristine.png'),
	   ('2300007', 'Fernandez, Joshua Miguel', 'Bachelor of Science in Information Technology', '3rd Year', '3IT-D', 'Enrolled', 'joshua.fernandez@gmail.com', '091245678901', 'Blk 35 Lot 10 Phase 6 Brgy. Marinig Cabuyao City Laguna', 'joshua.png'),
	   ('2300008', 'Torres, Camille Anne', 'Bachelor of Science in Information Technology', '3rd Year', '3IT-D', 'Enrolled', 'camille.torres@gmail.com', '091256789012', 'Blk 40 Lot 15 Phase 3 Brgy. Banay-Banay Cabuyao City Laguna', 'camille.png'),
	   ('2300009', 'Ramos, Kevin Paul', 'Bachelor of Science in Information Technology', '3rd Year', '3IT-D', 'Enrolled', 'kevin.ramos@gmail.com', '091267890123', 'Blk 45 Lot 20 Phase 2 Brgy. Mamatid Cabuyao City Laguna', 'kevin.png'),
	   ('2300010', 'Morales, Patricia Rose', 'Bachelor of Science in Information Technology', '3rd Year', '3IT-D', 'Enrolled', 'patricia.morales@gmail.com', '091278901234', 'Blk 50 Lot 25 Phase 4 Brgy. Marinig Cabuyao City Laguna', 'patricia.png');

-- View all records
SELECT * FROM students;