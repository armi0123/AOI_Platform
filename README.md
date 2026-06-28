# AOI Platform Demo

## 中文介紹

AOI Platform Demo 是一個使用 C# 與 Visual Studio 開發的模組化 AOI（Automated Optical Inspection，自動光學檢測）軟體架構專案。

本專案主要目標為學習工業 AOI 軟體架構設計，並模擬實際自動化設備與視覺檢測系統常見的功能模組，包含 PLC 通訊、檢測流程管理、系統設定管理、Log 紀錄以及模組化使用者介面設計。

系統採用 UserControl 模組化架構設計，讓各功能模組能夠獨立開發、維護與擴充，並以逐步建構完整 AOI 軟體平台為長期目標。

### 目前已完成功能

* PLC Monitor 模組
* Inspection Workflow 模組
* System Configuration 設定管理
* Log 紀錄系統
* Config.json 讀寫功能
* UserControl 模組化架構
* MainForm 模組協調機制
* Event-Driven 事件驅動架構
* Fake PLC Run 模擬測試
* Inspection → PLC 結果回傳流程

### 未來規劃

* Mitsubishi MC Protocol 通訊
* TCP/IP 通訊模組
* AOI Tool Pipeline 架構
* Camera Manager
* Recipe 管理系統
* 使用者權限管理
* Alarm 管理系統
* 資料庫整合
* AOI 檢測工具整合
* Cognex VisionPro 整合
* OpenCV 檢測工具整合
* MES / SCADA 串接練習

---

## 系統架構

本專案採用 WinForms + UserControl 的模組化架構設計，將不同功能拆分成獨立模組，並由 MainForm 作為各模組之間的事件串接與流程協調中心。

### 程式架構

```text
AOI Platform Demo
│
├── Forms
│   └── MainForm
│
├── UserControls
│   ├── ucInspection
│   ├── ucToolEditor
│   ├── ucPLCMonitor
│   ├── ucSystemConfig
│   └── ucLog
│
├── Core
│   ├── ConfigManager
│   └── LogManager
│
├── Model
│   └── ConfigParameter
│
├── Config
│   └── Config.json
│
├── Log
│   └── yyyyMMdd.txt
│
└── Program
```

### 模組角色說明

| 模組                | 功能說明                                          |
| ----------------- | --------------------------------------------- |
| MainForm.cs       | 系統主畫面，負責整合所有 UserControl 模組，並作為流程協調與事件串接中心    |
| ucInspection.cs   | 檢測流程模組，負責執行 AOI 檢測流程並回傳檢測結果                   |
| ucToolEditor.cs   | 工具管理模組，負責建立與設定 AOI 檢測工具，例如影像處理工具、條碼工具與 ROI 工具 |
| ucPLCMonitor.cs   | PLC 監控中心，負責監控 PLC 狀態並接收外部 Run 指令              |
| ucSystemConfig.cs | 系統設定中心，負責管理 PLC IP、通訊設定以及系統參數                 |
| ucLog.cs          | Log 管理中心，負責顯示與記錄系統執行訊息、錯誤訊息與運行狀態              |

### 流程運作範例

當 PLC Monitor 模組收到 PLC 傳來的 Run 指令時，系統流程如下：

```text
PLC Run Signal
      ↓
ucPLCMonitor.cs
      ↓
MainForm.cs 接收事件
      ↓
MainForm.cs 呼叫 ucInspection.cs
      ↓
ucInspection.cs 執行檢測流程
      ↓
取得檢測結果（OK / NG）
      ↓
MainForm.cs 傳遞結果
      ↓
ucPLCMonitor.cs
      ↓
回寫結果至 PLC
```

### 設計理念

本架構的核心設計目標為降低各模組之間的耦合度（Coupling）。

例如 ucPLCMonitor.cs 並不直接控制 ucInspection.cs，而是透過 MainForm.cs 進行事件串接與流程協調。

透過這種 Event-Driven 設計方式，可以讓 PLC 通訊、檢測流程、Log 管理與系統設定等功能模組彼此獨立開發與維護。

未來若需要更換 PLC 通訊方式、新增 AOI 檢測工具或擴充系統設定功能，都能降低對既有系統的影響，提高系統可維護性與擴充性。

---

## 與 AOI-ToolKit 的關係

AOI Platform Demo 與 AOI-ToolKit Demo 為互相搭配的學習專案，分別針對工業 AOI 軟體開發中不同層面的技術進行練習與實作。

### AOI-ToolKit Demo

主要開發內容：

* OpenCV 影像處理
* ROI 編輯功能
* Sobel 邊緣檢測
* QRCode 辨識
* Barcode 辨識
* DataMatrix 辨識
* AOI 檢測工具開發

主要目標為培養影像處理與電腦視覺相關技術能力。

### AOI Platform Demo

主要開發內容：

* PLC 通訊架構
* 檢測流程管理
* 系統設定管理
* Log 記錄系統
* 模組化 UserControl 設計
* Event-Driven 架構設計

主要目標為培養工業軟體架構設計與系統整合能力。

### 未來整合方向

未來規劃將 AOI-ToolKit 所開發的檢測工具整合至 AOI Platform 中，逐步建構成完整的工業 AOI 軟體平台。

預期架構如下：

```text
PLC
 ↓
AOI Platform
 ↓
Inspection Workflow
 ↓
AOI Tool Pipeline
 ↓
Threshold Tool
Sobel Tool
QRCode Tool
Barcode Tool
DataMatrix Tool
 ↓
Inspection Result
 ↓
PLC
```

在此架構中：

* AOI Platform 負責流程管理與系統架構
* AOI-ToolKit 負責實際影像檢測功能

兩者結合後，將形成完整的工業 AOI 軟體系統。

### 專案目標

除了學習 AOI 相關技術外，本專案也希望透過實際開發工業軟體架構、PLC 通訊與視覺檢測流程，累積接近實際產線 AOI 系統的開發經驗。

藉由持續擴充與優化，逐步建立符合工業自動化與智慧製造需求的 AOI 軟體平台。


-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
# AOI Platform Demo

## English Introduction

AOI Platform Demo is a modular AOI (Automated Optical Inspection) software architecture project developed using C# and Visual Studio.

The primary goal of this project is to learn industrial AOI software architecture design and simulate common functional modules found in real-world automation and inspection systems, including PLC communication, inspection workflow management, system configuration, logging, and modular UI design.

The system is built using a modular UserControl architecture, allowing each functional module to be developed, maintained, and expanded independently. The long-term goal is to evolve this project into a complete AOI software platform.

### Current Features

* PLC Monitor Module
* Inspection Workflow Module
* System Configuration Management
* Logging System
* Config.json Read / Write Support
* Modular UserControl Architecture
* MainForm Module Coordination
* Event-Driven Communication Mechanism
* Fake PLC Run Simulation
* Inspection Result Feedback to PLC

### Future Roadmap

* Mitsubishi MC Protocol Communication
* TCP/IP Communication Module
* AOI Tool Pipeline Framework
* Camera Manager
* Recipe Management System
* User Permission Management
* Alarm Management System
* Database Integration
* AOI Inspection Tool Integration
* Cognex VisionPro Integration
* OpenCV Inspection Tool Integration
* MES / SCADA Integration Practice

---

## System Architecture

This project adopts a WinForms + UserControl modular architecture, where different functions are separated into independent modules. MainForm serves as the coordination center responsible for event routing and workflow orchestration between modules.

### Project Structure

```text
AOI Platform Demo
│
├── Forms
│   └── MainForm
│
├── UserControls
│   ├── ucInspection
│   ├── ucToolEditor
│   ├── ucPLCMonitor
│   ├── ucSystemConfig
│   └── ucLog
│
├── Core
│   ├── ConfigManager
│   └── LogManager
│
├── Model
│   └── ConfigParameter
│
├── Config
│   └── Config.json
│
├── Log
│   └── yyyyMMdd.txt
│
└── Program
```

### Module Responsibilities

| Module            | Responsibility                                                                                                                                     |
| ----------------- | -------------------------------------------------------------------------------------------------------------------------------------------------- |
| MainForm.cs       | Main application window responsible for integrating all UserControl modules and coordinating workflow execution                                    |
| ucInspection.cs   | Inspection workflow module responsible for executing AOI inspection processes and returning inspection results                                     |
| ucToolEditor.cs   | Tool configuration module responsible for managing and configuring inspection tools such as image processing tools, barcode readers, and ROI tools |
| ucPLCMonitor.cs   | PLC monitoring center responsible for monitoring PLC status and receiving external Run commands                                                    |
| ucSystemConfig.cs | System configuration center responsible for managing PLC IP, communication settings, and system parameters                                         |
| ucLog.cs          | Logging center responsible for displaying and recording runtime messages, system status, and error information                                     |

### Example Workflow

When the PLC Monitor module receives a Run command from the PLC, the execution flow is as follows:

```text
PLC Run Signal
      ↓
ucPLCMonitor.cs
      ↓
MainForm.cs receives event
      ↓
MainForm.cs triggers ucInspection.cs
      ↓
ucInspection.cs executes inspection
      ↓
Inspection Result (OK / NG)
      ↓
MainForm.cs forwards result
      ↓
ucPLCMonitor.cs
      ↓
Write Result Back To PLC
```

### Design Concept

The primary design objective of this architecture is to reduce coupling between modules.

For example, ucPLCMonitor.cs does not directly control ucInspection.cs. Instead, all communication is coordinated through MainForm.cs using an event-driven approach.

This design allows PLC communication, inspection workflows, logging, and system configuration modules to be developed independently. Future modifications, such as replacing the PLC communication layer, adding new inspection tools, or extending system configurations, can be implemented with minimal impact on other modules.

---

## Relationship with AOI-ToolKit

AOI Platform Demo and AOI-ToolKit Demo are complementary learning projects that focus on different aspects of industrial AOI software development.

### AOI-ToolKit Demo

Focus Areas:

* OpenCV Image Processing
* ROI Editing
* Sobel Edge Detection
* QRCode Recognition
* Barcode Recognition
* DataMatrix Recognition
* AOI Inspection Tool Development

The primary objective is to develop computer vision and image processing capabilities.

### AOI Platform Demo

Focus Areas:

* PLC Communication Architecture
* Inspection Workflow Management
* System Configuration Management
* Logging System
* Modular UserControl Design
* Event-Driven Architecture

The primary objective is to develop industrial software architecture and system integration skills.

### Future Integration Plan

The long-term goal is to integrate the inspection tools developed in AOI-ToolKit into AOI Platform, transforming AOI Platform into a fully functional industrial AOI software platform.

Expected architecture:

```text
PLC
 ↓
AOI Platform
 ↓
Inspection Workflow
 ↓
AOI Tool Pipeline
 ↓
Threshold Tool
Sobel Tool
QRCode Tool
Barcode Tool
DataMatrix Tool
 ↓
Inspection Result
 ↓
PLC
```

In this architecture, AOI Platform is responsible for workflow orchestration and system architecture, while AOI-ToolKit provides the actual image inspection functionality. Together, they form a complete industrial AOI software solution.

### Project Goal

In addition to learning AOI technologies, this project aims to gain hands-on experience in industrial software architecture, PLC communication, and machine vision workflow development, closely simulating the architecture of real-world AOI systems used in manufacturing environments.

---
## 使用者介面展示

本專案採用 WinForms + UserControl 模組化設計，各功能頁面皆可獨立開發與維護，並透過 MainForm 進行整合與流程協調。

以下為目前已完成的主要功能及未來要新增的功能介面。

---

### MainForm

系統主畫面。

負責整合各功能模組，並提供使用者進入各功能頁面的入口，同時作為系統流程控制與事件串接中心。

#### 功能特色

* 模組化頁面管理(已完成)
* UserControl 動態載入(已完成)
* 系統狀態顯示
* 模組事件協調中心

<img width="637" height="410" alt="image" src="https://github.com/user-attachments/assets/64f2a0d7-0f17-4c19-96f5-a1eba944ef63" />

---

### PLC Monitor

PLC 訊號監控中心。

負責監控 PLC 狀態、接收 PLC 指令以及回傳檢測結果，目前已提供 Fake PLC 模式供開發與測試使用。

#### 功能特色

* PLC 連線狀態顯示
* PLC 訊號監控
* Run 指令接收
* Fake PLC 模擬測試(進行中)
* 檢測結果回傳

<img width="621" height="401" alt="image" src="https://github.com/user-attachments/assets/72d12e25-1087-41a2-bb86-c64e5e74639c" />

---

### Inspection

檢測流程管理中心。

負責執行 AOI 檢測流程，並根據檢測結果回傳 OK / NG 狀態。

目前以模擬檢測流程為主，未來將整合 AOI-ToolKit 的視覺檢測工具。

#### 功能特色

* 檢測流程控制
* 檢測結果管理
* Event 事件通知
* AOI Tool Pipeline 預留架構

<img width="621" height="400" alt="image" src="https://github.com/user-attachments/assets/80bad6ee-e81b-4200-b9fc-f9624fdd8fe8" />

---

### Tool Editor

檢測工具管理中心。

未來將提供 AOI 檢測工具新增、刪除、排序與參數設定功能，並支援建立完整的檢測流程。

#### 規劃功能

* Tool 新增與移除
* Tool 參數設定
* Pipeline 順序管理
* 檢測流程編輯

<img width="621" height="401" alt="image" src="https://github.com/user-attachments/assets/3a9d431b-0df3-4b0c-8a05-9cdb43c394a5" />

---

### System Config

系統環境設定中心。

負責管理 PLC 通訊設定、系統參數與運行模式設定。

目前已完成 Config.json 的讀寫功能。

#### 功能特色

* PLC IP 設定(已完成)
* PLC Port 設定(已完成)
* 通訊模式設定
* Config.json 儲存與載入(已完成)
* Fake PLC 模式切換(已完成)

<img width="621" height="401" alt="image" src="https://github.com/user-attachments/assets/cc0fc1bd-d8e8-4450-a4c9-5d128516c5a0" />

---

### Log Viewer

系統訊息管理中心。

負責記錄系統執行狀態、錯誤訊息與操作紀錄，方便後續除錯與問題追蹤。

#### 功能特色

* Log 即時顯示(已完成)
* 錯誤訊息記錄(已完成)
* 系統事件記錄(已完成)
* Log 檔案儲存(已完成)

<img width="624" height="402" alt="image" src="https://github.com/user-attachments/assets/b1f6fb2a-4fe9-4acb-89b1-b544e37901fc" />
