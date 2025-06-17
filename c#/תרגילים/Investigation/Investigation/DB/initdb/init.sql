
CREATE TABLE Players (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Level INT NOT NULL
);


CREATE TABLE Agents (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    IdPlayer INT NOT NULL,
    Type VARCHAR(50) NOT NULL,
    Name VARCHAR(100) NOT NULL,
    IsActive BOOLEAN NOT NULL DEFAULT TRUE,
    PulseSensor INT DEFAULT 0, AudioSensor INT DEFAULT 0, LightSensor INT DEFAULT 0, SignalSensor INT DEFAULT 0, MagneticSensor INT DEFAULT 0, ThermalSensor INT DEFAULT 0,
    FOREIGN KEY (IdPlayer) REFERENCES Players(Id)
);


CREATE TABLE Sensors (
    AgentId INT NOT NULL,
    SensorName ENUM('PulseSensor', 'AudioSensor', 'LightSensor', 'SignalSensor', 'MagneticSensor', 'ThermalSensor') NOT NULL,
    FOREIGN KEY (AgentId) REFERENCES Agents(Id)
);

INSERT INTO Players (Id, Name, Level) VALUES (1, 'Player A', 1);
INSERT INTO Players (Id, Name, Level) VALUES (2, 'Player B', 2);
INSERT INTO Agents (Id, IdPlayer, Type, Name, IsActive, PulseSensor, AudioSensor, LightSensor, SignalSensor, MagneticSensor, ThermalSensor) VALUES (1, 1, 'Rank2Agent', 'Rank2Agent_Player A', TRUE, 0, 1, 0, 0, 1, 0);
INSERT INTO Agents (Id, IdPlayer, Type, Name, IsActive, PulseSensor, AudioSensor, LightSensor, SignalSensor, MagneticSensor, ThermalSensor) VALUES (2, 1, 'Rank4Agent', 'Rank4Agent_Player A', TRUE, 2, 0, 0, 0, 1, 0);
INSERT INTO Agents (Id, IdPlayer, Type, Name, IsActive, PulseSensor, AudioSensor, LightSensor, SignalSensor, MagneticSensor, ThermalSensor) VALUES (3, 1, 'Rank6Agent', 'Rank6Agent_Player A', TRUE, 0, 0, 0, 2, 0, 2);
INSERT INTO Agents (Id, IdPlayer, Type, Name, IsActive, PulseSensor, AudioSensor, LightSensor, SignalSensor, MagneticSensor, ThermalSensor) VALUES (4, 1, 'Rank8Agent', 'Rank8Agent_Player A', TRUE, 0, 2, 2, 0, 1, 0);
INSERT INTO Agents (Id, IdPlayer, Type, Name, IsActive, PulseSensor, AudioSensor, LightSensor, SignalSensor, MagneticSensor, ThermalSensor) VALUES (5, 2, 'Rank2Agent', 'Rank2Agent_Player B', TRUE, 2, 0, 0, 0, 0, 0);
INSERT INTO Agents (Id, IdPlayer, Type, Name, IsActive, PulseSensor, AudioSensor, LightSensor, SignalSensor, MagneticSensor, ThermalSensor) VALUES (6, 2, 'Rank4Agent', 'Rank4Agent_Player B', TRUE, 0, 1, 1, 1, 0, 0);
INSERT INTO Agents (Id, IdPlayer, Type, Name, IsActive, PulseSensor, AudioSensor, LightSensor, SignalSensor, MagneticSensor, ThermalSensor) VALUES (7, 2, 'Rank6Agent', 'Rank6Agent_Player B', TRUE, 0, 0, 1, 0, 3, 0);
INSERT INTO Agents (Id, IdPlayer, Type, Name, IsActive, PulseSensor, AudioSensor, LightSensor, SignalSensor, MagneticSensor, ThermalSensor) VALUES (8, 2, 'Rank8Agent', 'Rank8Agent_Player B', TRUE, 0, 0, 0, 3, 0, 2);
INSERT INTO Sensors (AgentId, SensorName) VALUES (1, 'ThermalSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (1, 'MagneticSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (2, 'PulseSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (2, 'SignalSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (2, 'LightSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (3, 'SignalSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (3, 'MagneticSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (3, 'ThermalSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (3, 'PulseSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (4, 'MagneticSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (4, 'PulseSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (4, 'SignalSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (4, 'AudioSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (4, 'ThermalSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (5, 'SignalSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (5, 'PulseSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (6, 'AudioSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (6, 'PulseSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (6, 'LightSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (7, 'SignalSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (7, 'ThermalSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (7, 'PulseSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (7, 'LightSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (8, 'PulseSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (8, 'AudioSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (8, 'LightSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (8, 'ThermalSensor');
INSERT INTO Sensors (AgentId, SensorName) VALUES (8, 'MagneticSensor');